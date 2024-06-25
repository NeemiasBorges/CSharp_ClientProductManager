using MetroSet_UI.Controls;

namespace FormView.View.VendasView
{
    partial class VendasListView
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
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnImprimir = new DataGridViewButtonColumn();
            btnVisualizar = new DataGridViewButtonColumn();
            btnExcluir = new DataGridViewButtonColumn();
            btn_backView = new MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnVisualizar, btnImprimir, btnExcluir });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 289);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // 
            // btnVisualizar
            // 
            btnVisualizar.HeaderText = "Visualizar";
            btnVisualizar.MinimumWidth = 6;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseColumnTextForButtonValue = true;
            btnVisualizar.Width = 125;
            // 
            // btnImprimir
            // 
            btnImprimir.HeaderText = "Imprimir";
            btnImprimir.MinimumWidth = 6;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseColumnTextForButtonValue = true;
            btnImprimir.Width = 125;
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.MinimumWidth = 6;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            btnExcluir.Width = 125;



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
            btn_backView.Location = new Point(282, 350);
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
            // ClienteListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_backView);
            Controls.Add(dataGridView1);
            Name = "ClienteListView";
            Text = "Listagem de Produto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private MetroSet_UI.Controls.MetroSetButton btn_backView;
        private DataGridViewButtonColumn btnImprimir;
        private DataGridViewButtonColumn btnVisualizar;
        private DataGridViewButtonColumn btnExcluir;
    }
}