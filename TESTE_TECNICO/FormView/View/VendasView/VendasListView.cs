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
            LoadVendas();
        }

        public async Task LoadVendas()
        {
            var vendas = await _vendasService.Listar();
            dataGridView1.DataSource = vendas.ToList();
        }

        private void ProdutoListView_Load(object sender, EventArgs e)
        {

        }

        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
