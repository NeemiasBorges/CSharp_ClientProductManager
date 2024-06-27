using Aplicacao.DTO;
using Aplicacao.Service;
using FormView.Database;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormView.View.VendasView
{
    public partial class VendasAdd : Form
    {
        private ClienteService _clienteService = new ClienteService(DbInit._connectionString);
        private VendaService   _vendaService   = new VendaService(DbInit._connectionString);

        public VendasAdd()
        {
            InitializeComponent();
            InitializeMetroSetListBox();
        }

        public async void InitializeMetroSetListBox()
        {
            List<ClienteDTO> clientes = await _clienteService.Listar();
            foreach (var produto in clientes)
            {
                metroSetComboBox1.DataSource = clientes;
                metroSetComboBox1.DisplayMember = "Nome";
                metroSetComboBox1.ValueMember = "Id";
            }
        }

        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void metroSetButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var vendaDTO        = CriarVendaDTO();
                vendaDTO.VendaCorpo = ObterVendaCorpoDTOsSelecionados();

                await _vendaService.Inserir(vendaDTO);
                MessageBox.Show("Pedido de Venda criado com sucesso.");
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar a venda: {ex.Message}!");
                Log.Error($"Erro ao processar a venda: {ex.Message}", ex);
            }
        }

        private VendaDTO CriarVendaDTO()
        {
            if (metroSetComboBox1.SelectedValue == null)
                throw new InvalidOperationException("Cliente não selecionado.");

            return new VendaDTO
            {
                DataCriacao = dateTimePicker1.Value,
                IdCliente = int.Parse(metroSetComboBox1.SelectedValue.ToString())
            };
        }

        private List<VendaCorpoDTO> ObterVendaCorpoDTOsSelecionados()
        {
            var vendaCorpoList = new List<VendaCorpoDTO>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var vendaCorpoDTO = CriarVendaCorpoDTO(row);
                if (vendaCorpoDTO != null)
                {
                    vendaCorpoList.Add(vendaCorpoDTO);
                }
            }

            return vendaCorpoList;
        }

        private VendaCorpoDTO CriarVendaCorpoDTO(DataGridViewRow row)
        {
            if (row == null) throw new ArgumentNullException(nameof(row));

            if (row.Cells["productColumn"].Value == null ||
                row.Cells["quantityColumn"].Value == null ||
                row.Cells["valueColumn"].Value == null)
            {
                return null; 
            }

            return new VendaCorpoDTO
            {
                IdProduto = Convert.ToInt32(row.Cells["productColumn"].Value),
                Quantidade = Convert.ToDouble(row.Cells["quantityColumn"].Value),
                Preco = Convert.ToSingle(row.Cells["valueColumn"].Value)
            };
        }


        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
