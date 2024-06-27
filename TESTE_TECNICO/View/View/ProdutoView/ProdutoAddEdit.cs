using Aplicacao.DTO;
using Aplicacao.Service;
using FormView.Database;
using System;
using System.Windows.Forms;

namespace FormView.View.ProdutoView
{
    public partial class ClienteAddEdit : Form
    {
        ProdutoService _vendasService = new ProdutoService(DbInit._connectionString);
        public ClienteAddEdit(ProdutoDTO produto)
        {
            InitializeComponent(produto);
        }

        public async void btn_SalvarProd_Click(object sender, EventArgs e)
        {
            try
            {
                int id_prod      = Temporary_id;
                string nome      = textBox1.Text ?? "";
                string descricao = textBox2.Text ?? "";
                string precoText = textBox3.Text ?? "";

                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("O campo Descrição é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!float.TryParse(precoText, out float preco))
                {
                    MessageBox.Show("O campo Preço deve ser um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProdutoDTO produto = new ProdutoDTO(id_prod, nome, descricao, preco);

                await _vendasService.Atualizar(produto);
                MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                ClienteListView produtoList = new ClienteListView();
                //produtoList.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro ao atualizar o produto, verique os logs. {err.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Text(object sender, EventArgs e)
        {

        }

        private void textBox2_Text(object sender, EventArgs e)
        {

        }

        private void textBox3_Text(object sender, EventArgs e)
        {

        }

        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
