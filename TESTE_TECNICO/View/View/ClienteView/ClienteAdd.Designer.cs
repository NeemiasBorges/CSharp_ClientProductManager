using System.Drawing;
using System.Windows.Forms;

namespace FormView.View.ClienteView
{
    partial class ClienteAdd
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
            btn_SalvarCli = new MetroSet_UI.Controls.MetroSetButton();
            btn_backView = new MetroSet_UI.Controls.MetroSetButton();
            metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            lblName = new MetroSet_UI.Controls.MetroSetLabel();
            nome_TxtBox = new TextBox();
            end_TextBox = new TextBox();
            telefone_TextBox = new TextBox();
            lblDesc = new MetroSet_UI.Controls.MetroSetLabel();
            lblPreco = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            email_TextBox = new TextBox();
            SuspendLayout();
            // 
            // btn_SalvarCli
            // 
            btn_SalvarCli.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btn_SalvarCli.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btn_SalvarCli.DisabledForeColor = Color.Gray;
            btn_SalvarCli.Font = new Font("Microsoft Sans Serif", 10F);
            btn_SalvarCli.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btn_SalvarCli.HoverColor = Color.FromArgb(95, 207, 255);
            btn_SalvarCli.HoverTextColor = Color.White;
            btn_SalvarCli.IsDerivedStyle = true;
            btn_SalvarCli.Location = new Point(55, 323);
            btn_SalvarCli.Name = "btn_SalvarCli";
            btn_SalvarCli.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btn_SalvarCli.NormalColor = Color.FromArgb(65, 177, 225);
            btn_SalvarCli.NormalTextColor = Color.White;
            btn_SalvarCli.PressBorderColor = Color.FromArgb(35, 147, 195);
            btn_SalvarCli.PressColor = Color.FromArgb(35, 147, 195);
            btn_SalvarCli.PressTextColor = Color.White;
            btn_SalvarCli.Size = new Size(211, 51);
            btn_SalvarCli.Style = MetroSet_UI.Enums.Style.Light;
            btn_SalvarCli.StyleManager = null;
            btn_SalvarCli.TabIndex = 0;
            btn_SalvarCli.Text = "Salvar Cliente";
            btn_SalvarCli.ThemeAuthor = "Narwin";
            btn_SalvarCli.ThemeName = "MetroLite";
            btn_SalvarCli.Click += btn_SalvarCli_Click;
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
            btn_backView.Location = new Point(294, 323);
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
            metroSetDivider1.Location = new Point(55, 297);
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
            // nome_TxtBox
            // 
            nome_TxtBox.Location = new Point(186, 62);
            nome_TxtBox.Name = "nome_TxtBox";
            nome_TxtBox.Size = new Size(319, 27);
            nome_TxtBox.TabIndex = 5;
            // 
            // end_TextBox
            // 
            end_TextBox.Location = new Point(186, 119);
            end_TextBox.Name = "end_TextBox";
            end_TextBox.Size = new Size(319, 27);
            end_TextBox.TabIndex = 6;
            // 
            // telefone_TextBox
            // 
            telefone_TextBox.Location = new Point(186, 173);
            telefone_TextBox.Name = "telefone_TextBox";
            telefone_TextBox.Size = new Size(319, 27);
            telefone_TextBox.TabIndex = 7;
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
            lblDesc.Text = "Endereço";
            lblDesc.ThemeAuthor = "Narwin";
            lblDesc.ThemeName = "MetroLite";
            lblDesc.Click += lblDesc_Click;
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
            lblPreco.Text = "Telefone";
            lblPreco.ThemeAuthor = "Narwin";
            lblPreco.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(55, 233);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(125, 29);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 11;
            metroSetLabel1.Text = "Email";
            metroSetLabel1.TextAlign = ContentAlignment.MiddleLeft;
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // email_TextBox
            // 
            email_TextBox.Location = new Point(186, 233);
            email_TextBox.Name = "email_TextBox";
            email_TextBox.Size = new Size(319, 27);
            email_TextBox.TabIndex = 10;
            // 
            // ClienteAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 406);
            Controls.Add(metroSetLabel1);
            Controls.Add(email_TextBox);
            Controls.Add(lblPreco);
            Controls.Add(lblDesc);
            Controls.Add(telefone_TextBox);
            Controls.Add(end_TextBox);
            Controls.Add(nome_TxtBox);
            Controls.Add(lblName);
            Controls.Add(metroSetDivider2);
            Controls.Add(metroSetDivider1);
            Controls.Add(btn_backView);
            Controls.Add(btn_SalvarCli);
            Name = "ClienteAdd";
            Text = "Adicionar Cliente";
            Load += ClienteAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btn_SalvarCli;
        private MetroSet_UI.Controls.MetroSetButton btn_backView;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetLabel lblName;
        private TextBox nome_TxtBox;
        private TextBox end_TextBox;
        private TextBox telefone_TextBox;
        private MetroSet_UI.Controls.MetroSetLabel lblDesc;
        private MetroSet_UI.Controls.MetroSetLabel lblPreco;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private TextBox email_TextBox;
    }
}