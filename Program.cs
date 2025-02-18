// See https://aka.ms/new-console-template for more information

using WatchDoge.ApiClient;
using WatchDoge.Export;

Console.WriteLine("Hello, Doge!");

var client = new DogeClient();
var receipts = await client.GetReceipts();

if (receipts == null)
    throw new Exception("No response from Doge");

var contractExporter = new ContractCsvExport();
var leaseExporter = new LeaseCsvExport();

if (receipts.Contracts == null || receipts.Contracts.Count == 0)
    throw new Exception("No contracts found");

contractExporter.Export(receipts.Contracts);

if (receipts.Leases == null || receipts.Leases.Count == 0)
    return;
    
leaseExporter.Export(receipts.Leases);