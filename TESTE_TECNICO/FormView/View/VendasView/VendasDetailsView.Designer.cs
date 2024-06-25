using System.Windows.Forms;
using Aplicacao.DTO;
using MetroSet_UI.Controls; 

namespace FormView.View.VendasView
{
    partial class VendasDetailsView
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
        private void InitializeComponent(VendaDTO venda)
        {
            btn_backView = new MetroSetButton();
            btnSaveEditPv = new MetroSetButton();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            gridDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDetails).BeginInit();
            SuspendLayout();
            // 
            // btn_backView
            // 
            btn_backView.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btn_backView.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btn_backView.DisabledForeColor = Color.Gray;
            btn_backView.Font = new Font("Microsoft Sans Serif", 10F);
            btn_backView.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btn_backView.HoverColor = Color.FromArgb(95, 207, 255);
            btn_backView.HoverTextColor = Color.White;
            btn_backView.IsDerivedStyle = false;
            btn_backView.Location = new Point(430, 351);
            btn_backView.Name = "btn_backView";
            btn_backView.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btn_backView.NormalColor = Color.White;
            btn_backView.NormalTextColor = Color.CadetBlue;
            btn_backView.PressBorderColor = Color.FromArgb(35, 147, 195);
            btn_backView.PressColor = Color.FromArgb(35, 147, 195);
            btn_backView.PressTextColor = Color.LightSeaGreen;
            btn_backView.Size = new Size(211, 51);
            btn_backView.Style = MetroSet_UI.Enums.Style.Light;
            btn_backView.StyleManager = null;
            btn_backView.TabIndex = 3;
            btn_backView.Text = "Voltar";
            btn_backView.ThemeAuthor = "Narwin";
            btn_backView.ThemeName = "MetroLite";
            btn_backView.Click += btn_backView_Click;
            // 
            // btnSaveEditPv
            // 
            btnSaveEditPv.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnSaveEditPv.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnSaveEditPv.DisabledForeColor = Color.Gray;
            btnSaveEditPv.Font = new Font("Microsoft Sans Serif", 10F);
            btnSaveEditPv.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnSaveEditPv.HoverColor = Color.FromArgb(95, 207, 255);
            btnSaveEditPv.HoverTextColor = Color.White;
            btnSaveEditPv.IsDerivedStyle = true;
            btnSaveEditPv.Location = new Point(188, 351);
            btnSaveEditPv.Name = "btnSaveEditPv";
            btnSaveEditPv.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnSaveEditPv.NormalColor = Color.FromArgb(65, 177, 225);
            btnSaveEditPv.NormalTextColor = Color.White;
            btnSaveEditPv.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnSaveEditPv.PressColor = Color.FromArgb(35, 147, 195);
            btnSaveEditPv.PressTextColor = Color.White;
            btnSaveEditPv.Size = new Size(211, 51);
            btnSaveEditPv.Style = MetroSet_UI.Enums.Style.Light;
            btnSaveEditPv.StyleManager = null;
            btnSaveEditPv.TabIndex = 4;
            btnSaveEditPv.Text = "Salvar";
            btnSaveEditPv.ThemeAuthor = "Narwin";
            btnSaveEditPv.ThemeName = "MetroLite";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = venda.IdCliente.ToString();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(494, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = venda.DataCriacao;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 16);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 16);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 8;
            label2.Text = "Data de Criação";
            // 
            // gridDetails
            // 
            gridDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetails.DataSource = venda.VendaCorpo;
            gridDetails.Location = new Point(78, 116);
            gridDetails.Name = "gridDetails";
            gridDetails.RowHeadersWidth = 51;
            gridDetails.Size = new Size(666, 188);
            gridDetails.TabIndex = 9;
            // 
            // VendasDetailsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridDetails);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(btnSaveEditPv);
            Controls.Add(btn_backView);
            Name = "VendasDetailsView";
            Text = "Listagem de Produto";
            ((System.ComponentModel.ISupportInitialize)gridDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MetroSet_UI.Controls.MetroSetButton btn_backView;
        private MetroSetButton btnSaveEditPv;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DataGridView gridDetails;
    }
}