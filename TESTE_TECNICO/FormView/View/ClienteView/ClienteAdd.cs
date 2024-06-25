using Aplicacao.DTO;
using Aplicacao.Service;
using FormView.Database;

namespace FormView.View.ClienteView
{
    public partial class ClienteAdd : Form
    {
        ClienteService _clienteService = new ClienteService(DbInit._connectionString);
        public ClienteAdd()
        {
            InitializeComponent();
        }

        private async void btn_SalvarCli_Click(object sender, EventArgs e)
        {
            try
            {
                string Nome        = nome_TxtBox.Text;
                string txtEndereco = end_TextBox.Text;
                string txtTelefone = telefone_TextBox.Text;
                string Email       = email_TextBox.Text;

                if (string.IsNullOrWhiteSpace(Nome))
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEndereco))
                {
                    MessageBox.Show("O campo Endereco é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtTelefone))
                {
                    MessageBox.Show("O campo Telefone é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Email))
                {
                    MessageBox.Show("O campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClienteDTO cliente = new ClienteDTO(Nome, txtEndereco, txtTelefone, Email);

                await _clienteService.Inserir(cliente);

                MessageBox.Show("cliente salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro ao adicionar o cliente, verique os logs. {err.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_backView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void ClienteAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
