using System.Drawing;
using System.Windows.Forms;

namespace FormView.View.ProdutoView
{
    partial class ProdutoAdd
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
            btn_SalvarProd = new MetroSet_UI.Controls.MetroSetButton();
            btn_backView = new MetroSet_UI.Controls.MetroSetButton();
            metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            lblName = new MetroSet_UI.Controls.MetroSetLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblDesc = new MetroSet_UI.Controls.MetroSetLabel();
            lblPreco = new MetroSet_UI.Controls.MetroSetLabel();
            SuspendLayout();
            // 
            // btn_SalvarProd
            // 
            btn_SalvarProd.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btn_SalvarProd.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btn_SalvarProd.DisabledForeColor = Color.Gray;
            btn_SalvarProd.Font = new Font("Microsoft Sans Serif", 10F);
            btn_SalvarProd.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btn_SalvarProd.HoverColor = Color.FromArgb(95, 207, 255);
            btn_SalvarProd.HoverTextColor = Color.White;
            btn_SalvarProd.IsDerivedStyle = true;
            btn_SalvarProd.Location = new Point(55, 260);
            btn_SalvarProd.Name = "btn_SalvarProd";
            btn_SalvarProd.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btn_SalvarProd.NormalColor = Color.FromArgb(65, 177, 225);
            btn_SalvarProd.NormalTextColor = Color.White;
            btn_SalvarProd.PressBorderColor = Color.FromArgb(35, 147, 195);
            btn_SalvarProd.PressColor = Color.FromArgb(35, 147, 195);
            btn_SalvarProd.PressTextColor = Color.White;
            btn_SalvarProd.Size = new Size(211, 51);
            btn_SalvarProd.Style = MetroSet_UI.Enums.Style.Light;
            btn_SalvarProd.StyleManager = null;
            btn_SalvarProd.TabIndex = 0;
            btn_SalvarProd.Text = "Salvar Produto";
            btn_SalvarProd.ThemeAuthor = "Narwin";
            btn_SalvarProd.ThemeName = "MetroLite";
            btn_SalvarProd.Click += btn_SalvarProd_Click;
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
            btn_backView.Location = new Point(294, 260);
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
            btn_backView.TabIndex = 1;
            btn_backView.Text = "Voltar";
            btn_backView.ThemeAuthor = "Narwin";
            btn_backView.ThemeName = "MetroLite";
            btn_backView.Click += btn_backView_Click;
            // 
            // metroSetDivider1
            // 
            metroSetDivider1.IsDerivedStyle = true;
            metroSetDivider1.Location = new Point(55, 234);
            metroSetDivider1.Name = "metroSetDivider1";
            metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider1.Size = new Size(450, 4);
            metroSetDivider1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider1.StyleManager = null;
            metroSetDivider1.TabIndex = 2;
            metroSetDivider1.Text = "metroSetDivider1";
            metroSetDivider1.ThemeAuthor = "Narwin";
            metroSetDivider1.ThemeName = "MetroLite";
            metroSetDivider1.Thickness = 1;
            // 
            // metroSetDivider2
            // 
            metroSetDivider2.IsDerivedStyle = true;
            metroSetDivider2.Location = new Point(55, 33);
            metroSetDivider2.Name = "metroSetDivider2";
            metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider2.Size = new Size(450, 4);
            metroSetDivider2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider2.StyleManager = null;
            metroSetDivider2.TabIndex = 3;
            metroSetDivider2.Text = "metroSetDivider2";
            metroSetDivider2.ThemeAuthor = "Narwin";
            metroSetDivider2.ThemeName = "MetroLite";
            metroSetDivider2.Thickness = 1;
            // 
            // lblName
            // 
            lblName.Font = new Font("Microsoft Sans Serif", 10F);
            lblName.IsDerivedStyle = true;
            lblName.Location = new Point(55, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 29);
            lblName.Style = MetroSet_UI.Enums.Style.Light;
            lblName.StyleManager = null;
            lblName.TabIndex = 4;
            lblName.Text = "Nome";
            lblName.ThemeAuthor = "Narwin";
            lblName.ThemeName = "MetroLite";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(319, 27);
            textBox3.TabIndex = 7;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Microsoft Sans Serif", 10F);
            lblDesc.IsDerivedStyle = true;
            lblDesc.Location = new Point(55, 119);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(125, 29);
            lblDesc.Style = MetroSet_UI.Enums.Style.Light;
            lblDesc.StyleManager = null;
            lblDesc.TabIndex = 8;
            lblDesc.Text = "Descrição";
            lblDesc.ThemeAuthor = "Narwin";
            lblDesc.ThemeName = "MetroLite";
            // 
            // lblPreco
            // 
            lblPreco.Font = new Font("Microsoft Sans Serif", 10F);
            lblPreco.IsDerivedStyle = true;
            lblPreco.Location = new Point(55, 173);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(125, 29);
            lblPreco.Style = MetroSet_UI.Enums.Style.Light;
            lblPreco.StyleManager = null;
            lblPreco.TabIndex = 9;
            lblPreco.Text = "Preço";
            lblPreco.ThemeAuthor = "Narwin";
            lblPreco.ThemeName = "MetroLite";
            // 
            // ProdutoAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 337);
            Controls.Add(lblPreco);
            Controls.Add(lblDesc);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblName);
            Controls.Add(metroSetDivider2);
            Controls.Add(metroSetDivider1);
            Controls.Add(btn_backView);
            Controls.Add(btn_SalvarProd);
            Name = "ProdutoAdd";
            Text = "Adicionar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btn_SalvarProd;
        private MetroSet_UI.Controls.MetroSetButton btn_backView;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetLabel lblName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MetroSet_UI.Controls.MetroSetLabel lblDesc;
        private MetroSet_UI.Controls.MetroSetLabel lblPreco;
    }
}