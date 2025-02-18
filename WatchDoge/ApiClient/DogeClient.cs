using Newtonsoft.Json;
using WatchDoge.Model;

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
}