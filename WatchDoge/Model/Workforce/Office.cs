using Newtonsoft.Json;

namespace WatchDoge.Model.Workforce;

public class Office
{
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("parentId")]
    public string? ParentId { get; set; }
    
    [JsonProperty("sourceId")]
    public string? SourceId { get; set; }
    
    [JsonProperty("createdBy")]
    public string? CreatedBy { get; set; }
    
    [JsonProperty("updatedBy")]
    public string? UpdatedBy { get; set; }
    
    [JsonProperty("createdAt")]
    public DateTime? CreatedOn { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedOn { get; set; }
    
    [JsonProperty("statuteLink")]
    public string? StatuteLink { get; set; }
    
    [JsonProperty("fedscopeDivision")]
    public string? fedscopeDivision { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }
    
    [JsonProperty("childCount")]
    public int? ChildCount { get; set; }
}