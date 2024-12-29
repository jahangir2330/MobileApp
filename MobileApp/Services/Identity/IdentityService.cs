using System.Net;
using System.Text;
using MobileApp.Helpers;
using MobileApp.Models.Token;
using MobileApp.Services.RequestProvider;
using IdentityModel;
using PCLCrypto;
using static PCLCrypto.WinRTCrypto;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace MobileApp.Services.Identity;

public class IdentityService : IIdentityService
{
    private readonly IRequestProvider _requestProvider;
    private string _codeVerifier;

    public IdentityService(IRequestProvider requestProvider)
    {
        _requestProvider = requestProvider;
    }

    public string CreateAuthorizationRequest()
    {
        // Create URI to authorization endpoint
        var authorizeRequest = new AuthorizeRequest(GlobalSetting.Instance.AuthorizeEndpoint);

        // Dictionary with values for the authorize request
        Dictionary<string, string> dic = new()
        {
            { "client_id", GlobalSetting.Instance.ClientId },
            { "client_secret", GlobalSetting.Instance.ClientSecret },
            { "response_type", "code id_token" },
            { "scope", "openid profile basket orders offline_access" },
            { "redirect_uri", GlobalSetting.Instance.Callback },
            { "nonce", Guid.NewGuid().ToString("N") },
            { "code_challenge", CreateCodeChallenge() },
            { "code_challenge_method", "S256" }
        };

        // Add CSRF token to protect against cross-site request forgery attacks.
        var currentCSRFToken = Guid.NewGuid().ToString("N");
        dic.Add("state", currentCSRFToken);

        var authorizeUri = authorizeRequest.Create(dic);
        return authorizeUri;
    }

    public string CreateLogoutRequest(string token)
    {
        if (string.IsNullOrEmpty(token))
        {
            return string.Empty;
        }

        var settings = GlobalSetting.Instance;
        var (endpoint, callback) =
            (settings.LogoutEndpoint, settings.LogoutCallback);

        return $"{endpoint}?id_token_hint={token}&post_logout_redirect_uri={callback}";
    }
    public async Task<UserToken> GetTokenAsync(string code)
    {
        string data = string.Format("grant_type=authorization_code&code={0}&redirect_uri={1}&code_verifier={2}", code, WebUtility.UrlEncode(GlobalSetting.Instance.Callback), _codeVerifier);
        var token = await _requestProvider.PostAsync<UserToken>(GlobalSetting.Instance.TokenEndpoint, data, GlobalSetting.Instance.ClientId, GlobalSetting.Instance.ClientSecret);
        return token;
    }


    public async Task<apiAccessToken> GetToken(string userName, string password, string remoteipaddress)
    {
        try
        {
            apiAccessToken dynamicObject = new apiAccessToken();
            var model = new
            {
                UserName = userName,
                Password = password,
                RemoteIpAddress = remoteipaddress
            };

            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(GlobalSetting.DefaultEndpoint+"/api/Auth/login", model);

                response.EnsureSuccessStatusCode();
                string apiResponse = await response.Content.ReadAsStringAsync();
                dynamicObject = JsonConvert.DeserializeObject<apiAccessToken>(apiResponse)!;
            }
            return dynamicObject;
        }
        catch (Exception ex)
        {
            var s = ex.Message;
            throw;
        }
    }
   

    private string CreateCodeChallenge()
    {
        _codeVerifier = RandomNumberGenerator.CreateUniqueId();
        var sha256 = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha256);
        var challengeBuffer = sha256.HashData(CryptographicBuffer.CreateFromByteArray(Encoding.UTF8.GetBytes(_codeVerifier)));
        CryptographicBuffer.CopyToByteArray(challengeBuffer, out byte[] challengeBytes);
        return Base64Url.Encode(challengeBytes);
    }
}
