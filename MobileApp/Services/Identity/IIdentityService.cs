using BDO.Core.DataAccessObjects.ExtendedEntities;
using MobileApp.Models.Token;

namespace MobileApp.Services.Identity;

public interface IIdentityService
{
    string CreateAuthorizationRequest();
    string CreateLogoutRequest(string token);
    Task<UserToken> GetTokenAsync(string code);
    Task<apiAccessToken> GetToken(string userName, string password, string remoteipaddress);
}
