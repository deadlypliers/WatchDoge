using System.Globalization;
using CsvHelper;
using WatchDoge.Model;

namespace WatchDoge.Export;

public class ContractCsvExport
{
    private readonly string _fileName = $"ContractCsvExport {DateTime.Now.ToUniversalTime():yy-MM-dd h.mm.ss}.csv";
    private readonly string _savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

    public void Export(List<Contract> contracts)
    {
        using var writer = new CsvWriter(new StreamWriter(_savePath + "\\" + _fileName), CultureInfo.CurrentCulture);
        writer.WriteHeader<Contract>();
        writer.NextRecord();
        writer.WriteRecords(contracts);
    }
}