using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Services;
using WinUI.Models;
using ClosedXML.Excel;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace WinUI.Pages
{
    public partial class ReportingPage : UserControl
    {
        private readonly ILogService _logService;

        public ReportingPage(ILogService logService)
        {
            _logService = logService;
            InitializeComponent();
        }

        private void ReportingPage_Load(object sender, EventArgs e)
        {
            ComboBoxReportType.Items.AddRange(new object[] { "Ölçüm", "Kalibrasyon", "Numune", "Kayıt" });
            ComboBoxReportType.SelectedIndex = 0;
            RadioButtonDaily.Checked = true;
            RadioButtonSortByFirst.Checked = true;
        }

        private void SetRange(TimeSpan span)
        {
            var now = DateTime.Now;
            var start = now - span;
            DateTimePickerFirstDate.Value = start.Date;
            DateTimePickerFirstTime.Value = start;
            DateTimePickerLastDate.Value = now.Date;
            DateTimePickerLastTime.Value = now;
        }

        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxDate.Enabled = RadioButtonCustom.Checked;
        }

        private void RadioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonMonthly.Checked)
            {
                GroupBoxDate.Enabled = false;
                SetRange(TimeSpan.FromDays(30));
            }
        }

        private void RadioButtonWeekly_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonWeekly.Checked)
            {
                GroupBoxDate.Enabled = false;
                SetRange(TimeSpan.FromDays(7));
            }
        }

        private void RadioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonDaily.Checked)
            {
                GroupBoxDate.Enabled = false;
                SetRange(TimeSpan.FromDays(1));
            }
        }

        private async void ButtonGenerate_Click(object sender, EventArgs e)
        {
            DateTime start = DateTimePickerFirstDate.Value.Date + DateTimePickerFirstTime.Value.TimeOfDay;
            DateTime end = DateTimePickerLastDate.Value.Date + DateTimePickerLastTime.Value.TimeOfDay;
            bool desc = RadioButtonSortByLast.Checked;

            if (ComboBoxReportType.SelectedItem?.ToString() == "Kayıt")
            {
                var logs = await _logService.GetLogsAsync(start, end, desc) ?? new List<LogDto>();
                DataGridViewDatas.AutoGenerateColumns = false;
                DataGridViewDatas.Columns.Clear();
                DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Seviye", DataPropertyName = nameof(LogDto.Level) });
                DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mesaj", DataPropertyName = nameof(LogDto.Message) });
                DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tarih", DataPropertyName = nameof(LogDto.LoggedAt) });
                DataGridViewDatas.DataSource = logs;
            }
        }

        private void ButtonSaveAsExcel_Click(object sender, EventArgs e)
        {
            if (DataGridViewDatas.DataSource is not List<LogDto> logs || logs.Count == 0)
                return;
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Files|*.xlsx";
            dialog.FileName = $"logs_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using var workbook = new XLWorkbook();
                var ws = workbook.Worksheets.Add("Logs");
                ws.Cell(1, 1).Value = "Seviye";
                ws.Cell(1, 2).Value = "Mesaj";
                ws.Cell(1, 3).Value = "Tarih";
                for (int i = 0; i < logs.Count; i++)
                {
                    ws.Cell(i + 2, 1).Value = logs[i].Level;
                    ws.Cell(i + 2, 2).Value = logs[i].Message;
                    ws.Cell(i + 2, 3).Value = logs[i].LoggedAt;
                }
                workbook.SaveAs(dialog.FileName);
            }
        }

        private void ButtonSaveAsPdf_Click(object sender, EventArgs e)
        {
            if (DataGridViewDatas.DataSource is not List<LogDto> logs || logs.Count == 0)
                return;
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF Files|*.pdf";
            dialog.FileName = $"logs_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                QuestPDF.Settings.License = LicenseType.Community;
                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(20);
                        page.Content().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(80);
                                columns.RelativeColumn();
                                columns.ConstantColumn(150);
                            });
                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("Seviye");
                                header.Cell().Element(CellStyle).Text("Mesaj");
                                header.Cell().Element(CellStyle).Text("Tarih");
                            });
                            foreach (var log in logs)
                            {
                                table.Cell().Element(CellStyle).Text(log.Level);
                                table.Cell().Element(CellStyle).Text(log.Message);
                                table.Cell().Element(CellStyle).Text(log.LoggedAt.ToString("g"));
                            }
                        });
                    });
                }).GeneratePdf(dialog.FileName);
            }
        }

        private static IContainer CellStyle(IContainer container)
            => container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(2);
    }
}
