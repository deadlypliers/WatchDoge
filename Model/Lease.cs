using Newtonsoft.Json;

namespace WatchDoge.Model;

public class Lease
{
    [JsonProperty("sq_ft")]
    public double? SquareFeet { get; set; }
    
    [JsonProperty("date")]
    public string? Date { get; set; }
    
    [JsonProperty("location")]
    public string? Location { get; set; }
    
    [JsonProperty("description")]
    public string? Description { get; set; }
    
    [JsonProperty("ceiling_value")]
    public double? AnnualLeaseAmount { get; set; }
    
    [JsonProperty("value")]
    public double? Savings { get; set; }
    
    [JsonProperty("agency")]
    public string? Agency { get; set; }
}