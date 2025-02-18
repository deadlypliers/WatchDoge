using Newtonsoft.Json;
using WatchDoge.Model.Savings;
using WatchDoge.Model.Workforce;

namespace WatchDoge.ApiClient;

public class DogeClient
{
    private const string BASE_URL = "https://doge.gov";
    private const string SNAPSHOT_BASE_URL = "https://pub-1234b018e8b4435b92575fac089aa86f.r2.dev";
    private readonly HttpClient _client = new();

    public async Task<Receipts?> GetReceipts()
    {
        const string endpoint = BASE_URL + "/api/receipts/overview";
        var response = await _client.GetAsync(endpoint);

        var responseString = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Receipts>(responseString);
    }

    public async Task<OfficeResponse?> GetOfficeById(string officeId)
    {
        var endpoint = BASE_URL + $"/api/offices/{officeId}";
        var response = await _client.GetAsync(endpoint);
        
        var responseString = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<OfficeResponse>(responseString);
    }

    public async Task<KpiResponse?> GetKpiById(string officeId)
    {
        var endpoint = BASE_URL + $"/api/kpis/{officeId}";
        var response = await _client.GetAsync(endpoint);
        
        var responseString = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<KpiResponse>(responseString);
    }
}