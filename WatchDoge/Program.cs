// See https://aka.ms/new-console-template for more information

using WatchDoge.ApiClient;
using WatchDoge.Export;

Console.WriteLine("Hello, Doge!");

var client = new DogeClient();
var receipts = await client.GetReceipts();

if (receipts == null)
    throw new Exception("No response from Doge");

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