namespace Exemplo
{
    partial class frmProduto
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.txtRegiao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(168, 91);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(168, 117);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(304, 117);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(32, 91);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(124, 13);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Insira o valor do produto:";
            this.lblProduto.Click += new System.EventHandler(this.lblProduto_Click);
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Location = new System.Drawing.Point(32, 117);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(133, 13);
            this.lblRegiao.TabIndex = 4;
            this.lblRegiao.Text = "Insira o código do produto:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(32, 143);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(58, 13);
            this.lblRes.TabIndex = 12;
            this.lblRes.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(168, 143);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 13;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(690, 408);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(32, 169);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(44, 13);
            this.lblReg.TabIndex = 15;
            this.lblReg.Text = "Região:";
            // 
            // txtRegiao
            // 
            this.txtRegiao.Location = new System.Drawing.Point(168, 169);
            this.txtRegiao.Name = "txtRegiao";
            this.txtRegiao.ReadOnly = true;
            this.txtRegiao.Size = new System.Drawing.Size(100, 20);
            this.txtRegiao.TabIndex = 16;
            this.txtRegiao.TextChanged += new System.EventHandler(this.txtRegiao_TextChanged);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegiao);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblRegiao);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtProduto);
            this.Name = "frmProduto";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox txtRegiao;
    }
}