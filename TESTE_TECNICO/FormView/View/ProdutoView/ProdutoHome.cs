namespace FormView.View.ProdutoView
{
    public partial class ProdutoHome : Form
    {
        public ProdutoHome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProdutoAdd produtoAdd = new ProdutoAdd();
            produtoAdd.Show();
        }

        private void btnProdList_Click(object sender, EventArgs e)
        {
            ClienteListView produtoList = new ClienteListView();
            produtoList.Show();
        }

        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
