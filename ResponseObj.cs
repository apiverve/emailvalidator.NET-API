using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class smtp
{
    [JsonProperty("valid")]
    public bool valid { get; set; }

    [JsonProperty("reason")]
    public string reason { get; set; }

}

public class data
{
    [JsonProperty("creationDate")]
    public object creationDate { get; set; }

    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("email")]
    public string email { get; set; }

    [JsonProperty("username")]
    public string username { get; set; }

    [JsonProperty("canConnect")]
    public bool canConnect { get; set; }

    [JsonProperty("hasTypo")]
    public bool hasTypo { get; set; }

    [JsonProperty("isValid")]
    public bool isValid { get; set; }

    [JsonProperty("isMxValid")]
    public bool isMxValid { get; set; }

    [JsonProperty("isSmtpValid")]
    public bool isSmtpValid { get; set; }

    [JsonProperty("isRegexValid")]
    public bool isRegexValid { get; set; }

    [JsonProperty("smtp")]
    public smtp smtp { get; set; }

    [JsonProperty("isCompanyEmail")]
    public bool isCompanyEmail { get; set; }

    [JsonProperty("isFreeEmail")]
    public bool isFreeEmail { get; set; }

    [JsonProperty("isDisposable")]
    public bool isDisposable { get; set; }

    [JsonProperty("checksum")]
    public int checksum { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
