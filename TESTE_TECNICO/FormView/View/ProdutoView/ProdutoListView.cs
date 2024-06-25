using Aplicacao.Service;
using FormView.Database;

namespace FormView.View.ProdutoView
{
    public partial class ClienteListView : Form
    {
        ProdutoService _vendasService = new ProdutoService(DbInit._connectionString);
        public ClienteListView()
        {
            InitializeComponent();
            LoadProdutos();
        }

        public async Task LoadProdutos()
        {
            var produtos = await _vendasService.Listar();
            dataGridView1.DataSource = produtos.ToList();
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
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["btnEditar"].Index)
                {
                    int produtoId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    var produto = await _vendasService.BuscarPorId(produtoId);
                    this.Close();

                    ClienteAddEdit produtoEdit = new ClienteAddEdit(produto);
                    produtoEdit.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["btnExcluir"].Index)
                {
                    int produtoId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    await _vendasService.Deletar(produtoId);
                    await LoadProdutos();
                }
            }
        }

    }
}
