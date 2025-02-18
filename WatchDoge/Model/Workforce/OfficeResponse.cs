using Newtonsoft.Json;

namespace WatchDoge.Model.Workforce;

public class OfficeResponse
{
    [JsonProperty("office")]
    public Office? Office { get; set; }
    
    [JsonProperty("kpis")]
    public List<Kpi>? Kpis { get; set; }
    
    [JsonProperty("children")]
    public List<Office>? Children { get; set; }
}