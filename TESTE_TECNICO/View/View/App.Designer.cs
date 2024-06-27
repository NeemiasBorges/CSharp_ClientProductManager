
using System.Drawing;
using System.Windows.Forms;

namespace FormView
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            btnMenuClientes = new MetroSet_UI.Controls.MetroSetButton();
            btnMenuVendas = new MetroSet_UI.Controls.MetroSetButton();
            btnMenuProdutos = new MetroSet_UI.Controls.MetroSetButton();
            SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(819, 12);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 0;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // btnMenuClientes
            // 
            btnMenuClientes.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnMenuClientes.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnMenuClientes.DisabledForeColor = Color.Gray;
            btnMenuClientes.Font = new Font("Microsoft Sans Serif", 10F);
            btnMenuClientes.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnMenuClientes.HoverColor = Color.FromArgb(95, 207, 255);
            btnMenuClientes.HoverTextColor = Color.White;
            btnMenuClientes.IsDerivedStyle = true;
            btnMenuClientes.Location = new Point(26, 68);
            btnMenuClientes.Name = "btnMenuClientes";
            btnMenuClientes.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnMenuClientes.NormalColor = Color.FromArgb(65, 177, 225);
            btnMenuClientes.NormalTextColor = Color.White;
            btnMenuClientes.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnMenuClientes.PressColor = Color.FromArgb(35, 147, 195);
            btnMenuClientes.PressTextColor = Color.White;
            btnMenuClientes.Size = new Size(280, 152);
            btnMenuClientes.Style = MetroSet_UI.Enums.Style.Light;
            btnMenuClientes.StyleManager = null;
            btnMenuClientes.TabIndex = 1;
            btnMenuClientes.Text = "Menu Clientes";
            btnMenuClientes.ThemeAuthor = "Narwin";
            btnMenuClientes.ThemeName = "MetroLite";
            btnMenuClientes.Click += this.btnMenuClientes_Click;
            // 
            // btnMenuVendas
            // 
            btnMenuVendas.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnMenuVendas.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnMenuVendas.DisabledForeColor = Color.Gray;
            btnMenuVendas.Font = new Font("Microsoft Sans Serif", 10F);
            btnMenuVendas.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnMenuVendas.HoverColor = Color.FromArgb(95, 207, 255);
            btnMenuVendas.HoverTextColor = Color.White;
            btnMenuVendas.IsDerivedStyle = true;
            btnMenuVendas.Location = new Point(323, 68);
            btnMenuVendas.Name = "btnMenuVendas";
            btnMenuVendas.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnMenuVendas.NormalColor = Color.FromArgb(65, 177, 225);
            btnMenuVendas.NormalTextColor = Color.White;
            btnMenuVendas.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnMenuVendas.PressColor = Color.FromArgb(35, 147, 195);
            btnMenuVendas.PressTextColor = Color.White;
            btnMenuVendas.Size = new Size(280, 152);
            btnMenuVendas.Style = MetroSet_UI.Enums.Style.Light;
            btnMenuVendas.StyleManager = null;
            btnMenuVendas.TabIndex = 2;
            btnMenuVendas.Text = "Menu Vendas";
            btnMenuVendas.ThemeAuthor = "Narwin";
            btnMenuVendas.ThemeName = "MetroLite";
            btnMenuVendas.Click += this.btnMenuVendas_Click;
            // 
            // btnMenuProdutos
            // 
            btnMenuProdutos.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnMenuProdutos.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnMenuProdutos.DisabledForeColor = Color.Gray;
            btnMenuProdutos.Font = new Font("Microsoft Sans Serif", 10F);
            btnMenuProdutos.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnMenuProdutos.HoverColor = Color.FromArgb(95, 207, 255);
            btnMenuProdutos.HoverTextColor = Color.White;
            btnMenuProdutos.IsDerivedStyle = true;
            btnMenuProdutos.Location = new Point(620, 68);
            btnMenuProdutos.Name = "btnMenuProdutos";
            btnMenuProdutos.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnMenuProdutos.NormalColor = Color.FromArgb(65, 177, 225);
            btnMenuProdutos.NormalTextColor = Color.White;
            btnMenuProdutos.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnMenuProdutos.PressColor = Color.FromArgb(35, 147, 195);
            btnMenuProdutos.PressTextColor = Color.White;
            btnMenuProdutos.Size = new Size(280, 152);
            btnMenuProdutos.Style = MetroSet_UI.Enums.Style.Light;
            btnMenuProdutos.StyleManager = null;
            btnMenuProdutos.TabIndex = 3;
            btnMenuProdutos.Text = "Menu Produtos";
            btnMenuProdutos.ThemeAuthor = "Narwin";
            btnMenuProdutos.ThemeName = "MetroLite";
            btnMenuProdutos.Click += this.btnMenuProdutos_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 297);
            Controls.Add(btnMenuProdutos);
            Controls.Add(btnMenuVendas);
            Controls.Add(btnMenuClientes);
            Controls.Add(metroSetControlBox1);
            Name = "App";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

    
        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton btnMenuClientes;
        private MetroSet_UI.Controls.MetroSetButton btnMenuVendas;
        private MetroSet_UI.Controls.MetroSetButton btnMenuProdutos;
    }
}
