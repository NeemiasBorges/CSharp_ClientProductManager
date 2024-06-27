using Aplicacao.DTO;
using Aplicacao.Service;
using FormView.Database;
using System;
using System.Windows.Forms;

namespace FormView.View.VendasView
{
    public partial class VendasDetailsView : Form
    {
        VendaService _vendasService = new VendaService(DbInit._connectionString);
        public VendasDetailsView(VendaDTO venda)
        {
            InitializeComponent(venda);
        }

        private void VendasListView_Load(object sender, EventArgs e)
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
