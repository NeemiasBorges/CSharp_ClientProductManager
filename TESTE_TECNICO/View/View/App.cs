using FormView.View.ClienteView;
using FormView.View.ProdutoView;
using FormView.View.VendasView;
using System;
using Serilog;
using System.Windows.Forms;

namespace FormView
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuProdutos_Click(object sender, EventArgs e)
        {
            ProdutoHome produtoHome = new ProdutoHome();
            produtoHome.Show();
        }

        private void btnMenuVendas_Click(object sender, EventArgs e)
        {
            VendasHome vendasHome = new VendasHome();
            vendasHome.Show();
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            ClienteHome cliente = new ClienteHome();
            cliente.Show();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
