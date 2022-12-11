namespace Cadastro1
{
    partial class Form1
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
            this.txtbCod = new System.Windows.Forms.TextBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbQuant = new System.Windows.Forms.TextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPreco = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbCod
            // 
            this.txtbCod.Location = new System.Drawing.Point(148, 41);
            this.txtbCod.Name = "txtbCod";
            this.txtbCod.Size = new System.Drawing.Size(406, 23);
            this.txtbCod.TabIndex = 0;
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(148, 82);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(406, 23);
            this.txtbNome.TabIndex = 1;
            // 
            // txtbQuant
            // 
            this.txtbQuant.Location = new System.Drawing.Point(148, 123);
            this.txtbQuant.Name = "txtbQuant";
            this.txtbQuant.Size = new System.Drawing.Size(406, 23);
            this.txtbQuant.TabIndex = 2;
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(21, 44);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(91, 15);
            this.lblCodProd.TabIndex = 3;
            this.lblCodProd.Text = "Digite o código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade do prod.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite o preço:";
            // 
            // txtbPreco
            // 
            this.txtbPreco.Location = new System.Drawing.Point(148, 166);
            this.txtbPreco.Name = "txtbPreco";
            this.txtbPreco.Size = new System.Drawing.Size(406, 23);
            this.txtbPreco.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro1.Properties.Resources.New_Project__2_;
            this.pictureBox1.Location = new System.Drawing.Point(576, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(64, 214);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 59);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastre o Produto";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 295);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.txtbQuant);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.txtbCod);
            this.Name = "Form1";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbCod;
        private TextBox txtbNome;
        private TextBox txtbQuant;
        private Label lblCodProd;
        private Label lblNome;
        private Label label3;
        private Label label4;
        private TextBox txtbPreco;
        private PictureBox pictureBox1;
        private Button btnCadastrar;
    }
}