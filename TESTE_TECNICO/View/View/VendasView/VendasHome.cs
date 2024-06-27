using System;
using System.Windows.Forms;

namespace FormView.View.VendasView
{
    public partial class VendasHome : Form
    {
        public VendasHome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VendasAdd vendasAdd = new VendasAdd();
            vendasAdd.Show();
        }
        private void btnProdList_Click(object sender, EventArgs e)
        {
            VendasListView produtoList = new VendasListView();
            produtoList.Show();
        }

        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
