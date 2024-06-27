using Aplicacao.DTO;
using Aplicacao.Service;
using FormView.Database;
using System;
using System.Windows.Forms;

namespace FormView.View.ClienteView
{
    public partial class ClienteAddEdit : Form
    {
        ClienteService _cliService = new ClienteService(DbInit._connectionString);
        public ClienteAddEdit(ClienteDTO cliente)
        {
            InitializeComponent(cliente);
        }

        public async void btn_SalvarCli_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtBx_nome.Text.Trim();
                string idEnderecoText = txtBx_nome.Text.Trim();
                string idTelefoneText = txtBx_nome.Text.Trim();
                string email = txtBx_nome.Text.Trim();

                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(idEnderecoText) || !int.TryParse(idEnderecoText, out int idEndereco))
                {
                    MessageBox.Show("O campo IdEndereco é obrigatório e deve ser um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(idTelefoneText) || !int.TryParse(idTelefoneText, out int idTelefone))
                {
                    MessageBox.Show("O campo IdTelefone é obrigatório e deve ser um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
                {
                    MessageBox.Show("O campo Email é obrigatório e deve ser um endereço de email válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClienteDTO cliente = new ClienteDTO(nome, idEndereco, idTelefone, email);

                await _cliService.Atualizar(cliente);
                MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                ClienteListView clienteList = new ClienteListView();
                //clienteList.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro ao atualizar o produto, verifique os logs. {err.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
