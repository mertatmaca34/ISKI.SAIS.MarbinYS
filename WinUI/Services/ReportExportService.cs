using ClosedXML.Excel;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using WinUI.Models;

namespace WinUI.Services;

public interface IReportExportService
{
    void ExportLogsToExcel(IEnumerable<LogDto> logs, string filePath);
    void ExportLogsToPdf(IEnumerable<LogDto> logs, string filePath);
    void ExportMeasurementsToExcel(IEnumerable<ApiDataResultDto> measurements, string filePath);
}

public class ReportExportService : IReportExportService
{
    public void ExportLogsToExcel(IEnumerable<LogDto> logs, string filePath)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Logs");

        worksheet.Cell(1, 1).Value = "Id";
        worksheet.Cell(1, 2).Value = "Level";
        worksheet.Cell(1, 3).Value = "Message";
        worksheet.Cell(1, 4).Value = "Exception";
        worksheet.Cell(1, 5).Value = "Logged At";

        int row = 2;
        foreach (var log in logs)
        {
            worksheet.Cell(row, 1).Value = log.Id;
            worksheet.Cell(row, 2).Value = log.Level;
            worksheet.Cell(row, 3).Value = log.Message;
            worksheet.Cell(row, 4).Value = log.Exception ?? string.Empty;
            worksheet.Cell(row, 5).Value = log.LoggedAt;
            row++;
        }

        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
    }

    public void ExportLogsToPdf(IEnumerable<LogDto> logs, string filePath)
    {
        var document = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Margin(20);
                page.Content().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(40);
                        columns.RelativeColumn();
                        columns.RelativeColumn(2);
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(HeaderStyle).Text("Id");
                        header.Cell().Element(HeaderStyle).Text("Level");
                        header.Cell().Element(HeaderStyle).Text("Message");
                        header.Cell().Element(HeaderStyle).Text("Exception");
                        header.Cell().Element(HeaderStyle).Text("Logged At");
                    });

                    foreach (var log in logs)
                    {
                        table.Cell().Element(CellStyle).Text(log.Id.ToString());
                        table.Cell().Element(CellStyle).Text(log.Level);
                        table.Cell().Element(CellStyle).Text(log.Message);
                        table.Cell().Element(CellStyle).Text(log.Exception ?? string.Empty);
                        table.Cell().Element(CellStyle).Text(log.LoggedAt.ToString("s"));
                    }
                });

                static IContainer HeaderStyle(IContainer container) =>
                    container.DefaultTextStyle(x => x.SemiBold()).Padding(5).BorderBottom(1);

                static IContainer CellStyle(IContainer container) =>
                    container.Padding(5).BorderBottom(1);
            });
        });

        document.GeneratePdf(filePath);
    }

    public void ExportMeasurementsToExcel(IEnumerable<ApiDataResultDto> measurements, string filePath)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Measurements");

        worksheet.Cell(1, 1).Value = "Read Time";
        worksheet.Cell(1, 2).Value = "AKM";
        worksheet.Cell(1, 3).Value = "Debi";
        worksheet.Cell(1, 4).Value = "KOi";
        worksheet.Cell(1, 5).Value = "pH";
        worksheet.Cell(1, 6).Value = "Cozunmus Oksijen";
        worksheet.Cell(1, 7).Value = "Akis Hizi";
        worksheet.Cell(1, 8).Value = "Sicaklik";

        int row = 2;
        foreach (var m in measurements)
        {
            worksheet.Cell(row, 1).Value = m.ReadTime;
            worksheet.Cell(row, 2).Value = m.AKM;
            worksheet.Cell(row, 3).Value = m.Debi;
            worksheet.Cell(row, 4).Value = m.KOi;
            worksheet.Cell(row, 5).Value = m.pH;
            worksheet.Cell(row, 6).Value = m.CozunmusOksijen;
            worksheet.Cell(row, 7).Value = m.AkisHizi;
            worksheet.Cell(row, 8).Value = m.Sicaklik;
            row++;
        }

        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
    }
}

