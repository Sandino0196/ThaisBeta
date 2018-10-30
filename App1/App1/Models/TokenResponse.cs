using Newtonsoft.Json;

namespace App1.Models
{
    public class TokenResponse
    {
        #region Propiedades
            [JsonProperty(PropertyName = "accessToken")]
            public string AccessToken { get; set; }
            [JsonProperty(PropertyName = "tokenType")]
            public string TokenType { get; set; }
            [JsonProperty(PropertyName = "expiresIn")]
            public string ExpiresIn { get; set; }
            [JsonProperty(PropertyName = "userName")]
            public string UserName { get; set; }
            [JsonProperty(PropertyName = "issued")]
            public string Issued { get; set; }
            [JsonProperty(PropertyName = "expires")]
            public string Expires { get; set; }
            [JsonProperty(PropertyName = "errorDescription")]
            public string ErrorDescription { get; set; }
        #endregion
    }
}
