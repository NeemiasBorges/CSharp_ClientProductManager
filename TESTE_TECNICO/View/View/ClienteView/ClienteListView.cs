using Aplicacao.Service;
using FormView.Database;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView.View.ClienteView
{
    public partial class ClienteListView : Form
    {
        ClienteService _cliService = new ClienteService(DbInit._connectionString);
        public ClienteListView()
        {
            InitializeComponent();
            LoadClientes();
        }

        public async Task LoadClientes()
        {
            var clientes = await _cliService.Listar();
            dataGridView2.DataSource = clientes.ToList();
        }

        private void ClienteListView_Load(object sender, EventArgs e)
        {

        }

        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView2.Columns["btnEditar"].Index)
                {
                    int ClienteId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Id"].Value);
                    var Cliente = await _cliService.BuscarPorId(ClienteId);
                    this.Close();

                    ClienteAddEdit ClienteEdit = new ClienteAddEdit(Cliente);
                    ClienteEdit.Show();
                }
                else if (e.ColumnIndex == dataGridView2.Columns["btnExcluir"].Index)
                {
                    int ClienteId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Id"].Value);
                    await _cliService.Deletar(ClienteId);
                    await LoadClientes();
                }
            }
        }

        private void btn_SalvarProd_Click(object sender, EventArgs e)
        {

        }
    }
}
