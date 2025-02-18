using Newtonsoft.Json;

namespace WatchDoge.Model.Savings;

public class Receipts
{
    [JsonProperty("contracts")]
    public List<Contract>? Contracts { get; set; }
    
    [JsonProperty("leases")]
    public List<Lease>? Leases { get; set; }
}