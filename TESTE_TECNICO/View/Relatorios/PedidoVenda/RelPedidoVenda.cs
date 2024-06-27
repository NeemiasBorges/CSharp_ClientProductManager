using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportApp.Relatorio.PedidoVenda
{
    public partial class RelPedidoVenda : Form
    {
        private ReportViewer reportViewer1;

        public RelPedidoVenda()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
        }

        public async Task GerarRelatorio(Aplicacao.DTO.VendaDTO pedidoVenda)
        {
            try
            {
                reportViewer1 = new ReportViewer();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Relatorios\\PedidoVenda\\PedidoVenda.rdlc");
                reportViewer1.LocalReport.ReportPath = path;

                var firstItem = pedidoVenda.VendaCorpo.FirstOrDefault();
                string quantidade = firstItem != null ? firstItem.Quantidade.ToString() : "0";
                string preco = firstItem != null ? firstItem.Preco.ToString("F2") : "0.00";
                string descricao = string.Join(", ", pedidoVenda.VendaCorpo.Select(x => x.Descricao));

                var reportParameters = new List<ReportParameter>()
    {
        new ReportParameter("DataDoc", pedidoVenda.DataCriacao.ToString("dd/MM/yyyy")),
        new ReportParameter("DescricaoItem", descricao),
        new ReportParameter("Quantidade", quantidade),
        new ReportParameter("Preco", preco),
        new ReportParameter("NomeFornecedor", pedidoVenda.Fornecedor),
        new ReportParameter("DocTotal", $"R$ {pedidoVenda.VendaCorpo.Sum(x => (x.Preco * x.Quantidade)):F2}"),
        new ReportParameter("NumeroPV", pedidoVenda.Id.ToString())
    };
                reportViewer1.LocalReport.SetParameters(reportParameters);

                reportViewer1.RefreshReport();

                byte[] renderedBytes;
                string mimeType, encoding, fileNameExtension;
                string[] streams;
                Warning[] warnings;

                renderedBytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);

                using (MemoryStream memoryStream = new MemoryStream(renderedBytes))
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                        saveFileDialog.Title = "Salvar relatório como";
                        saveFileDialog.FileName = $"pedidoVenda{DateTime.Now:ddMMyyyy}.pdf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            File.WriteAllBytes(filePath, memoryStream.ToArray());

                            MessageBox.Show($"Relatório salvo em: {filePath}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            System.Diagnostics.Process.Start(filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
