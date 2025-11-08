using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Smtp data
    /// </summary>
    public class Smtp
    {
        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("creationDate")]
        public object CreationDate { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("canConnect")]
        public bool CanConnect { get; set; }

        [JsonProperty("hasTypo")]
        public bool HasTypo { get; set; }

        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("isMxValid")]
        public bool IsMxValid { get; set; }

        [JsonProperty("isSmtpValid")]
        public bool IsSmtpValid { get; set; }

        [JsonProperty("isRegexValid")]
        public bool IsRegexValid { get; set; }

        [JsonProperty("smtp")]
        public Smtp Smtp { get; set; }

        [JsonProperty("isCompanyEmail")]
        public bool IsCompanyEmail { get; set; }

        [JsonProperty("isFreeEmail")]
        public bool IsFreeEmail { get; set; }

        [JsonProperty("checksum")]
        public int Checksum { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
