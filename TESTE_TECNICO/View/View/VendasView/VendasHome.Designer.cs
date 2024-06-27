using System.Drawing;

namespace FormView.View.VendasView
{
    partial class VendasHome
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
            btnAdd = new MetroSet_UI.Controls.MetroSetButton();
            btnProdList = new MetroSet_UI.Controls.MetroSetButton();
            btn_backView = new MetroSet_UI.Controls.MetroSetButton();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnAdd.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnAdd.DisabledForeColor = Color.Gray;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdd.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnAdd.HoverColor = Color.FromArgb(95, 207, 255);
            btnAdd.HoverTextColor = Color.White;
            btnAdd.IsDerivedStyle = true;
            btnAdd.Location = new Point(23, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnAdd.NormalColor = Color.FromArgb(65, 177, 225);
            btnAdd.NormalTextColor = Color.White;
            btnAdd.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnAdd.PressColor = Color.FromArgb(35, 147, 195);
            btnAdd.PressTextColor = Color.White;
            btnAdd.Size = new Size(324, 178);
            btnAdd.Style = MetroSet_UI.Enums.Style.Light;
            btnAdd.StyleManager = null;
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Adicionar Novo Pedido de Vendas";
            btnAdd.ThemeAuthor = "Narwin";
            btnAdd.ThemeName = "MetroLite";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnProdList
            // 
            btnProdList.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnProdList.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnProdList.DisabledForeColor = Color.Gray;
            btnProdList.Font = new Font("Microsoft Sans Serif", 10F);
            btnProdList.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnProdList.HoverColor = Color.FromArgb(95, 207, 255);
            btnProdList.HoverTextColor = Color.White;
            btnProdList.IsDerivedStyle = true;
            btnProdList.Location = new Point(385, 24);
            btnProdList.Name = "btnProdList";
            btnProdList.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnProdList.NormalColor = Color.FromArgb(65, 177, 225);
            btnProdList.NormalTextColor = Color.White;
            btnProdList.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnProdList.PressColor = Color.FromArgb(35, 147, 195);
            btnProdList.PressTextColor = Color.White;
            btnProdList.Size = new Size(324, 178);
            btnProdList.Style = MetroSet_UI.Enums.Style.Light;
            btnProdList.StyleManager = null;
            btnProdList.TabIndex = 1;
            btnProdList.Text = "Listar Pedidos de Vendas";
            btnProdList.ThemeAuthor = "Narwin";
            btnProdList.ThemeName = "MetroLite";
            btnProdList.Click += btnProdList_Click;
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
            btn_backView.Location = new Point(259, 237);
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
            // VendasHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            ClientSize = new Size(730, 310);
            Controls.Add(btn_backView);
            Controls.Add(btnProdList);
            Controls.Add(btnAdd);
            Name = "VendasHome";
            Text = "Vendas Home";
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnAdd;
        private MetroSet_UI.Controls.MetroSetButton btnProdList;
        private MetroSet_UI.Controls.MetroSetButton btn_backView;
    }
}