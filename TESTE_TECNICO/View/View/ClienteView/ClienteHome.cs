using FormView.View.ClienteView;
using System;
using System.Windows.Forms;

namespace FormView.View.ClienteView
{
    public partial class ClienteHome : Form
    {
        public ClienteHome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClienteAdd clienteAdd = new ClienteAdd();
            clienteAdd.Show();
        }

        private void btnProdList_Click(object sender, EventArgs e)
        {
            ClienteListView clienteList = new ClienteListView();
            clienteList.Show();
        }

        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
