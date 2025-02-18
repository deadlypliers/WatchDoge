using Newtonsoft.Json;

namespace WatchDoge.Model.Workforce;

public class KpiResponse
{
    [JsonProperty("office_id")]
    public string? OfficeId { get; set; }

    [JsonProperty("office_name")]
    public string? OfficeName { get; set; }

    [JsonProperty("children_count")]
    public int? ChildrenCount { get; set; }

    [JsonProperty("aggregated")]
    public Kpi? AggregatedKpis { get; set; }
    
    [JsonProperty("detailed")]
    public Kpi? DetailedKpis { get; set; }
}