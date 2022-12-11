namespace Cadastro1
{
    partial class Form2
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
            this.txtbProcCod = new System.Windows.Forms.TextBox();
            this.cbProcNome = new System.Windows.Forms.ComboBox();
            this.lblProcCod = new System.Windows.Forms.Label();
            this.lblProcNome = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblMostraCod = new System.Windows.Forms.Label();
            this.lblMostraNome = new System.Windows.Forms.Label();
            this.lblMostraQuant = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblMostraPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbProcCod
            // 
            this.txtbProcCod.Location = new System.Drawing.Point(86, 30);
            this.txtbProcCod.Name = "txtbProcCod";
            this.txtbProcCod.Size = new System.Drawing.Size(156, 23);
            this.txtbProcCod.TabIndex = 0;
            // 
            // cbProcNome
            // 
            this.cbProcNome.FormattingEnabled = true;
            this.cbProcNome.Location = new System.Drawing.Point(86, 71);
            this.cbProcNome.Name = "cbProcNome";
            this.cbProcNome.Size = new System.Drawing.Size(156, 23);
            this.cbProcNome.TabIndex = 1;
            this.cbProcNome.SelectedIndexChanged += new System.EventHandler(this.cbProcNome_SelectedIndexChanged);
            // 
            // lblProcCod
            // 
            this.lblProcCod.AutoSize = true;
            this.lblProcCod.Location = new System.Drawing.Point(20, 33);
            this.lblProcCod.Name = "lblProcCod";
            this.lblProcCod.Size = new System.Drawing.Size(49, 15);
            this.lblProcCod.TabIndex = 2;
            this.lblProcCod.Text = "Código:";
            this.lblProcCod.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProcNome
            // 
            this.lblProcNome.AutoSize = true;
            this.lblProcNome.Location = new System.Drawing.Point(20, 74);
            this.lblProcNome.Name = "lblProcNome";
            this.lblProcNome.Size = new System.Drawing.Size(43, 15);
            this.lblProcNome.TabIndex = 3;
            this.lblProcNome.Text = "Nome:";
            this.lblProcNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(86, 272);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(318, 23);
            this.txtQuant.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 227);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 23);
            this.txtNome.TabIndex = 6;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(86, 178);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(221, 23);
            this.txtCod.TabIndex = 7;
            // 
            // lblMostraCod
            // 
            this.lblMostraCod.AutoSize = true;
            this.lblMostraCod.Location = new System.Drawing.Point(20, 186);
            this.lblMostraCod.Name = "lblMostraCod";
            this.lblMostraCod.Size = new System.Drawing.Size(49, 15);
            this.lblMostraCod.TabIndex = 8;
            this.lblMostraCod.Text = "Código:";
            // 
            // lblMostraNome
            // 
            this.lblMostraNome.AutoSize = true;
            this.lblMostraNome.Location = new System.Drawing.Point(20, 230);
            this.lblMostraNome.Name = "lblMostraNome";
            this.lblMostraNome.Size = new System.Drawing.Size(43, 15);
            this.lblMostraNome.TabIndex = 9;
            this.lblMostraNome.Text = "Nome:";
            // 
            // lblMostraQuant
            // 
            this.lblMostraQuant.AutoSize = true;
            this.lblMostraQuant.Location = new System.Drawing.Point(8, 275);
            this.lblMostraQuant.Name = "lblMostraQuant";
            this.lblMostraQuant.Size = new System.Drawing.Size(72, 15);
            this.lblMostraQuant.TabIndex = 10;
            this.lblMostraQuant.Text = "Quantidade:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(311, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 70);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(86, 316);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(363, 23);
            this.txtPreco.TabIndex = 12;
            // 
            // lblMostraPreco
            // 
            this.lblMostraPreco.AutoSize = true;
            this.lblMostraPreco.Location = new System.Drawing.Point(20, 319);
            this.lblMostraPreco.Name = "lblMostraPreco";
            this.lblMostraPreco.Size = new System.Drawing.Size(40, 15);
            this.lblMostraPreco.TabIndex = 13;
            this.lblMostraPreco.Text = "Preço:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 363);
            this.Controls.Add(this.lblMostraPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblMostraQuant);
            this.Controls.Add(this.lblMostraNome);
            this.Controls.Add(this.lblMostraCod);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.lblProcNome);
            this.Controls.Add(this.lblProcCod);
            this.Controls.Add(this.cbProcNome);
            this.Controls.Add(this.txtbProcCod);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbProcCod;
        private ComboBox cbProcNome;
        private Label lblProcCod;
        private Label lblProcNome;
        private TextBox txtQuant;
        private TextBox txtNome;
        private TextBox txtCod;
        private Label lblMostraCod;
        private Label lblMostraNome;
        private Label lblMostraQuant;
        private Button btnBuscar;
        private TextBox txtPreco;
        private Label lblMostraPreco;
    }
}