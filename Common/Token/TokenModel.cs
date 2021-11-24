﻿using System;

namespace Common.Token
{
    public class TokenModel
    {
        private string Token { get; }
        private long Expiration { get; }

        protected TokenModel(string token, long expiration)
        {
            if(string.IsNullOrWhiteSpace(token))
                throw new ArgumentException("Invalid token.");

            if(expiration <= 0)
                throw new ArgumentException("Invalid expiration.");

            Token = token;
            Expiration = expiration;
        }

        public bool IsExpired() => DateTime.UtcNow.Ticks > Expiration;
    }
}