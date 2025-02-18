using System.Globalization;
using CsvHelper;
using WatchDoge.Model;

namespace WatchDoge.Export;

public class CsvExport
{
    private readonly string _exportFilePath;
    private const string EXPORT_DIRECTORY = "Exports";

    public CsvExport(ExportType exportType)
    {
        var fileName = exportType switch
        {
            ExportType.Contract => $"ContractCsvExport {DateTime.Now.ToUniversalTime():yy-MM-dd h.mm.ss}.csv",
            ExportType.Lease => $"LeaseCsvExport {DateTime.Now.ToUniversalTime():yy-MM-dd h.mm.ss}.csv",
            ExportType.Office => $"OfficeCsvExport {DateTime.Now.ToUniversalTime():yy-MM-dd h.mm.ss}.csv",
            ExportType.Kpi => $"KpiCsvExport {DateTime.Now.ToUniversalTime():yy-MM-dd h.mm.ss}.csv",
            _ => throw new ArgumentOutOfRangeException(nameof(exportType), exportType, null)
        };

        //_exportFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
        _exportFilePath = Path.Combine(EXPORT_DIRECTORY, fileName);
    }

    public void Export<T>(List<T> exportData)
    {
        if (!Directory.Exists(EXPORT_DIRECTORY))
        {
            Directory.CreateDirectory(EXPORT_DIRECTORY);
        }
        
        using var writer = new CsvWriter(new StreamWriter(_exportFilePath), CultureInfo.CurrentCulture);
        writer.WriteHeader<T>();
        writer.NextRecord();
        writer.WriteRecords(exportData);
    }
}