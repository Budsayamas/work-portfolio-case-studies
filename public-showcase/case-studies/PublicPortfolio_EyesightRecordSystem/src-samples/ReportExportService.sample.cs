using System.Data;
using ClosedXML.Excel;

namespace PortfolioSamples.EyesightRecords;

public sealed class ReportExportService
{
    public void ExportMonthlyReport(
        DataTable reportData,
        string templatePath,
        string outputPath,
        int year,
        int month)
    {
        using var workbook = new XLWorkbook(templatePath);
        var worksheet = workbook.Worksheet("Report");

        worksheet.Cell("B2").Value = year;
        worksheet.Cell("B3").Value = month;
        worksheet.Cell("A5").InsertData(reportData.Rows);

        workbook.SaveAs(outputPath);
    }
}
