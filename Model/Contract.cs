using Newtonsoft.Json;

namespace WatchDoge.Model;

public class Contract
{
    [JsonProperty("piid")]
    public string? Id { get; set; }
    
    [JsonProperty("date")]
    public string? Date { get; set; }

    [JsonProperty("agency")]
    public string? Agency { get; set; }
    
    [JsonProperty("ceiling_value")]
    public decimal? TotalContract { get; set; }
    
    [JsonProperty("value")]
    public decimal? Savings { get; set; }
    
    [JsonProperty("update_date")]
    public string? UpdatedOn { get; set; }
    
    [JsonProperty("fpds_status")]
    public string? FpdsStatus { get; set; }
    
    [JsonProperty("fpds_link")]
    public string? FpdsLink { get; set; }
    
    [JsonProperty("vendor")]
    public string? Vendor { get; set; }
    
    [JsonProperty("description")]
    public string? Description { get; set; }
}