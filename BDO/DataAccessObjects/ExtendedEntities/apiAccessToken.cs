using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public sealed class apiAccessToken
    {
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public bool success { get; set; }
        public int expiresIn { get; }
    }
}
