using Aplicacao.Service;
using FormView.Database;

namespace FormView.View.VendasView
{
    public partial class VendasListView : Form
    {
        VendaService _vendasService = new VendaService(DbInit._connectionString);
        public VendasListView()
        {
            InitializeComponent();
            //InitializeReportViewer();
            LoadVendas();
        }

        public async Task LoadVendas()
        {
            var vendas                                 = await _vendasService.Listar();
            dataGridView1.DataSource                   = vendas.ToList();
            dataGridView1.Columns["Id"].Visible        = false;
            dataGridView1.Columns["IdCliente"].Visible = false;
            dataGridView1.Columns["IdUsuario"].Visible = false;
        }

        private async void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            if (e.ColumnIndex == dataGridView1.Columns["btnVisualizar"].Index && e.RowIndex >= 0)
            {
                var pedidoVenda = await _vendasService.BuscarPorId(id);
                VendasDetailsView vendasDetailsView = new VendasDetailsView(pedidoVenda);
                vendasDetailsView.Show(); 
            }

            if (e.ColumnIndex == dataGridView1.Columns["btnExcluir"].Index && e.RowIndex >= 0)
            {
                await _vendasService.Deletar(id);
                MessageBox.Show("Pedido de Venda deletada com sucesso");
            }

            if (e.ColumnIndex == dataGridView1.Columns["btnImprimir"].Index && e.RowIndex >= 0)
            {
                var pedidoVenda = await _vendasService.BuscarPorId(id);

                //PassarDadosParaReportViewer(pedidoVenda);
                //reportViewer1.RefreshReport();
                await _vendasService.GerarRelatorio(pedidoVenda);
                MessageBox.Show("Relatório de Pedido de Venda Gerado com Sucesso!");
            }

            await LoadVendas();
        }

        //private void PassarDadosParaReportViewer(VendaDTO dados)
        //{
        //    reportViewer1.LocalReport.DataSources.Clear();
        //    ReportDataSource rds = new ReportDataSource("DataSetPedidoVenda", dados);
        //    reportViewer1.LocalReport.DataSources.Add(rds);
        //    reportViewer1.LocalReport.ReportEmbeddedResource = "FormView.Relatorios.PedidoVenda.rdlc";
        //}


        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
