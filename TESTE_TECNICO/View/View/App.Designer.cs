
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.btnMenuClientes = new MetroSet_UI.Controls.MetroSetButton();
            this.btnMenuVendas = new MetroSet_UI.Controls.MetroSetButton();
            this.btnMenuProdutos = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(819, 10);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuClientes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuClientes.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnMenuClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMenuClientes.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMenuClientes.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMenuClientes.HoverTextColor = System.Drawing.Color.White;
            this.btnMenuClientes.IsDerivedStyle = true;
            this.btnMenuClientes.Location = new System.Drawing.Point(26, 54);
            this.btnMenuClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuClientes.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuClientes.NormalTextColor = System.Drawing.Color.White;
            this.btnMenuClientes.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMenuClientes.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMenuClientes.PressTextColor = System.Drawing.Color.White;
            this.btnMenuClientes.Size = new System.Drawing.Size(280, 122);
            this.btnMenuClientes.Style = MetroSet_UI.Enums.Style.Light;
            this.btnMenuClientes.StyleManager = null;
            this.btnMenuClientes.TabIndex = 1;
            this.btnMenuClientes.Text = "Menu Clientes";
            this.btnMenuClientes.ThemeAuthor = "Narwin";
            this.btnMenuClientes.ThemeName = "MetroLite";
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            // 
            // btnMenuVendas
            // 
            this.btnMenuVendas.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuVendas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuVendas.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnMenuVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMenuVendas.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMenuVendas.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMenuVendas.HoverTextColor = System.Drawing.Color.White;
            this.btnMenuVendas.IsDerivedStyle = true;
            this.btnMenuVendas.Location = new System.Drawing.Point(323, 54);
            this.btnMenuVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuVendas.Name = "btnMenuVendas";
            this.btnMenuVendas.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuVendas.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuVendas.NormalTextColor = System.Drawing.Color.White;
            this.btnMenuVendas.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMenuVendas.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMenuVendas.PressTextColor = System.Drawing.Color.White;
            this.btnMenuVendas.Size = new System.Drawing.Size(280, 122);
            this.btnMenuVendas.Style = MetroSet_UI.Enums.Style.Light;
            this.btnMenuVendas.StyleManager = null;
            this.btnMenuVendas.TabIndex = 2;
            this.btnMenuVendas.Text = "Menu Vendas";
            this.btnMenuVendas.ThemeAuthor = "Narwin";
            this.btnMenuVendas.ThemeName = "MetroLite";
            this.btnMenuVendas.Click += new System.EventHandler(this.btnMenuVendas_Click);
            // 
            // btnMenuProdutos
            // 
            this.btnMenuProdutos.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuProdutos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuProdutos.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnMenuProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMenuProdutos.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMenuProdutos.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMenuProdutos.HoverTextColor = System.Drawing.Color.White;
            this.btnMenuProdutos.IsDerivedStyle = true;
            this.btnMenuProdutos.Location = new System.Drawing.Point(620, 54);
            this.btnMenuProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuProdutos.Name = "btnMenuProdutos";
            this.btnMenuProdutos.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuProdutos.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMenuProdutos.NormalTextColor = System.Drawing.Color.White;
            this.btnMenuProdutos.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMenuProdutos.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMenuProdutos.PressTextColor = System.Drawing.Color.White;
            this.btnMenuProdutos.Size = new System.Drawing.Size(280, 122);
            this.btnMenuProdutos.Style = MetroSet_UI.Enums.Style.Light;
            this.btnMenuProdutos.StyleManager = null;
            this.btnMenuProdutos.TabIndex = 3;
            this.btnMenuProdutos.Text = "Menu Produtos";
            this.btnMenuProdutos.ThemeAuthor = "Narwin";
            this.btnMenuProdutos.ThemeName = "MetroLite";
            this.btnMenuProdutos.Click += new System.EventHandler(this.btnMenuProdutos_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 238);
            this.Controls.Add(this.btnMenuProdutos);
            this.Controls.Add(this.btnMenuVendas);
            this.Controls.Add(this.btnMenuClientes);
            this.Controls.Add(this.metroSetControlBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);

        }

    
        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton btnMenuClientes;
        private MetroSet_UI.Controls.MetroSetButton btnMenuVendas;
        private MetroSet_UI.Controls.MetroSetButton btnMenuProdutos;
    }
}
