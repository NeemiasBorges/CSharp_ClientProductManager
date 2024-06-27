
using Aplicacao.DTO;
using Aplicacao.Service;
using FormView.Database;
using Serilog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView.View.VendasView
{
    partial class VendasAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private async void InitializeComponent()
        {
            metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            dataGridView1 = new DataGridView();
            incrementalColumn = new DataGridViewTextBoxColumn();
            productColumn = new DataGridViewComboBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            valueColumn = new DataGridViewTextBoxColumn();
            deleteButtonColumn = new DataGridViewButtonColumn();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            metroSetComboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // metroSetButton1
            // 
            metroSetButton1.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton1.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton1.DisabledForeColor = Color.Gray;
            metroSetButton1.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetButton1.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton1.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton1.HoverTextColor = Color.White;
            metroSetButton1.IsDerivedStyle = true;
            metroSetButton1.Location = new Point(123, 407);
            metroSetButton1.Name = "metroSetButton1";
            metroSetButton1.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton1.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton1.NormalTextColor = Color.White;
            metroSetButton1.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton1.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton1.PressTextColor = Color.White;
            metroSetButton1.Size = new Size(209, 56);
            metroSetButton1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetButton1.StyleManager = null;
            metroSetButton1.TabIndex = 0;
            metroSetButton1.Text = "Adicionar Pedido de Vendas";
            metroSetButton1.ThemeAuthor = "Narwin";
            metroSetButton1.ThemeName = "MetroLite";
            metroSetButton1.Click += metroSetButton1_Click;
            // 
            // metroSetButton2
            // 
            metroSetButton2.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton2.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton2.DisabledForeColor = Color.Gray;
            metroSetButton2.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetButton2.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton2.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton2.HoverTextColor = Color.White;
            metroSetButton2.IsDerivedStyle = false;
            metroSetButton2.Location = new Point(354, 407);
            metroSetButton2.Name = "metroSetButton2";
            metroSetButton2.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton2.NormalColor = Color.White;
            metroSetButton2.NormalTextColor = Color.SteelBlue;
            metroSetButton2.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton2.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton2.PressTextColor = Color.White;
            metroSetButton2.Size = new Size(209, 56);
            metroSetButton2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetButton2.StyleManager = null;
            metroSetButton2.TabIndex = 1;
            metroSetButton2.Text = "Voltar";
            metroSetButton2.ThemeAuthor = "Narwin";
            metroSetButton2.ThemeName = "MetroLite";
            metroSetButton2.Click += metroSetButton2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { incrementalColumn, productColumn, quantityColumn, valueColumn, deleteButtonColumn });
            dataGridView1.Location = new Point(49, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(634, 188);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowPostPaint += DataGridView1_RowPostPaint;
            // 
            // incrementalColumn
            // 
            incrementalColumn.HeaderText = "#";
            incrementalColumn.MinimumWidth = 6;
            incrementalColumn.Name = "incrementalColumn";
            incrementalColumn.Width = 125;
            // 
            // productColumn
            // 
            productColumn.HeaderText = "Produto";
            productColumn.MinimumWidth = 6;
            productColumn.Name = "productColumn";
            productColumn.Width = 125;
            // 
            // quantityColumn
            // 
            quantityColumn.HeaderText = "Quantidade";
            quantityColumn.MinimumWidth = 6;
            quantityColumn.Name = "quantityColumn";
            quantityColumn.Width = 125;
            // 
            // valueColumn
            // 
            valueColumn.HeaderText = "Valor";
            valueColumn.MinimumWidth = 6;
            valueColumn.Name = "valueColumn";
            valueColumn.Width = 125;
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.HeaderText = " Del ";
            deleteButtonColumn.MinimumWidth = 6;
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(433, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "Fornecedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Data";
            // 
            // metroSetComboBox1
            // 
            metroSetComboBox1.AllowDrop = true;
            metroSetComboBox1.ArrowColor = Color.FromArgb(150, 150, 150);
            metroSetComboBox1.BackColor = Color.Transparent;
            metroSetComboBox1.BackgroundColor = Color.FromArgb(238, 238, 238);
            metroSetComboBox1.BorderColor = Color.FromArgb(150, 150, 150);
            metroSetComboBox1.CausesValidation = false;
            metroSetComboBox1.DisabledBackColor = Color.FromArgb(204, 204, 204);
            metroSetComboBox1.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            metroSetComboBox1.DisabledForeColor = Color.FromArgb(136, 136, 136);
            metroSetComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            metroSetComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            metroSetComboBox1.Font = new Font("Microsoft Sans Serif", 11F);
            metroSetComboBox1.FormattingEnabled = true;
            metroSetComboBox1.IsDerivedStyle = true;
            metroSetComboBox1.ItemHeight = 20;
            metroSetComboBox1.Location = new Point(49, 38);
            metroSetComboBox1.Name = "metroSetComboBox1";
            metroSetComboBox1.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            metroSetComboBox1.SelectedItemForeColor = Color.White;
            metroSetComboBox1.Size = new Size(210, 26);
            metroSetComboBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetComboBox1.StyleManager = null;
            metroSetComboBox1.TabIndex = 8;
            metroSetComboBox1.ThemeAuthor = "Narwin";
            metroSetComboBox1.ThemeName = "MetroLite";
            metroSetComboBox1.SelectedIndexChanged += metroSetComboBox1_SelectedIndexChanged;
            // 
            // VendasAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 499);
            Controls.Add(metroSetComboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(metroSetButton2);
            Controls.Add(metroSetButton1);
            Name = "VendasAdd";
            Text = "Formulario de Vendas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();

            await LoadProductListAsync();
            ResumeLayout(false);
            PerformLayout();
        }

        ProdutoService _produtoService = new ProdutoService(DbInit._connectionString);

        private async Task LoadProductListAsync()
        {
            try
            {
                var productList = await GetProductList();

                if (dataGridView1.Columns["productColumn"] is DataGridViewComboBoxColumn productColumn)
                {
                    productColumn.DataSource = productList;
                    productColumn.DisplayMember = "Nome";
                    productColumn.ValueMember = "Id";
                }
                else
                {
                    Log.Error("A coluna 'productColumn' não foi encontrada.");
                }
            }
            catch (Exception e)
            {
                Log.Error($"Erro ao carregar todos os produtos: {e.Message}", e);
            }
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["incrementalColumn"].Value = e.RowIndex + 1;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }



        private async Task<List<ProdutoDTO>> GetProductList()
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            produtos = await _produtoService.Listar();
            return produtos;
        }
        #endregion

        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn incrementalColumn;
        private DataGridViewComboBoxColumn productColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private DataGridViewTextBoxColumn valueColumn;
        private DataGridViewButtonColumn deleteButtonColumn;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox1;
    }
}