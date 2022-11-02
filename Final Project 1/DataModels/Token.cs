using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientLibrary.DataModels
{
    class TokenTo
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}