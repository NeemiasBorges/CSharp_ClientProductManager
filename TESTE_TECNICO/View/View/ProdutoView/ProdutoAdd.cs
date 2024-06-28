using Aplicacao.DTO;
using Aplicacao.Service;
using FormView.Database;
using System;
using System.Windows.Forms;

namespace FormView.View.ProdutoView
{
    public partial class ProdutoAdd : Form
    {
        ProdutoService _vendasService = new ProdutoService(DbInit._connectionString);
        public ProdutoAdd()
        {
            InitializeComponent();
        }

        private async void btn_SalvarProd_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBox1.Text;
                string descricao = textBox2.Text;
                string precoText = textBox3.Text;

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

                ProdutoDTO produto = new ProdutoDTO(nome, descricao, preco);

                await _vendasService.Inserir(produto);
                MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception err)
            {
                AppLogger.Logger.Error(err.Message);
                MessageBox.Show($"Erro ao adicionar o produto, verique os logs. {err.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
