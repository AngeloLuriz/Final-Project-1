using HttpClientLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientLibrary.Tests.TestData
{
    class Token
    {
        public static TokenModel credentials()
        {
            return new TokenModel
            {
                Username = "admin",
                Password = "password123"
            };
        }
    }
}