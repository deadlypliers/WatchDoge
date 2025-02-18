// See https://aka.ms/new-console-template for more information

using WatchDoge.ApiClient;
using WatchDoge.Export;
using WatchDoge.Model.Workforce;

Console.WriteLine("Hello, Doge!");

var client = new DogeClient();

// "Savings" section
var receipts = await client.GetReceipts();

if (receipts == null)
    throw new Exception("No savings data in response from Doge");

var contractExporter = new CsvExport(ExportType.Contract);
var leaseExporter = new CsvExport(ExportType.Lease);

if (receipts.Contracts is { Count: > 0 })
{
    contractExporter.Export(receipts.Contracts);
}

if (receipts.Leases is { Count: > 0 })
{
    leaseExporter.Export(receipts.Leases);
}

// "Workforce" section
var baseOrgResponse = await client.GetOfficeById("Federal_Government");

if (baseOrgResponse?.Office is null)
{
    throw new Exception("No office data in response from Doge");
}

var baseOrgKpiResponse = await client.GetKpiById(baseOrgResponse.Office.Id);

if (baseOrgKpiResponse?.AggregatedKpis is null)
{
    throw new Exception("No kpi data in response from Doge");
}

var baseOrg = new List<Office> { baseOrgResponse.Office };
var baseOrgKpis = new List<Kpi> { baseOrgKpiResponse.AggregatedKpis };

var officeExporter = new CsvExport(ExportType.Office);
var kpiExporter = new CsvExport(ExportType.Kpi);

officeExporter.Export(baseOrg);
kpiExporter.Export(baseOrgKpis);

// TODO: Recurse through child offices to get office stats and KPIs