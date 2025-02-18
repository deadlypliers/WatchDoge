using System.Globalization;
using CsvHelper;
using WatchDoge.Model;

namespace WatchDoge.Export;

public class LeaseCsvExport
{
    private readonly string _fileName = $"LeaseCsvExport {DateTime.Now.ToUniversalTime():yy-MM-dd h.mm.ss}.csv";
    private readonly string _savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

    public void Export(List<Lease> leases)
    {
        using var writer = new CsvWriter(new StreamWriter(_savePath + "\\" + _fileName), CultureInfo.CurrentCulture);
        writer.WriteHeader<Lease>();
        writer.NextRecord();
        writer.WriteRecords(leases);
    }
}