﻿using System;

namespace Models.BotAuth
{
    [Serializable]
    public class AuthResult
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string UserName { get; set; }
        public string UserUniqueId { get; set; }
        public long ExpiresOnUtcTicks { get; set; }
        public byte[] TokenCache { get; set; }
        public string IdentityProvider { get; set; }
    }
}
