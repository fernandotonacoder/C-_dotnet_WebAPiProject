using System.Text.Json.Serialization;


public class DataStructure
{
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("result")]
    public Result Result { get; set; }
}

public class Result
{
    [JsonPropertyName("postcode")]
    public string Postcode { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }
}