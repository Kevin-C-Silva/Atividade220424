﻿namespace Exemplo
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoDeDescontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.línguaNativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somaToolStripMenuItem,
            this.cálculoDeDescontoToolStripMenuItem,
            this.línguaNativaToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            this.programasToolStripMenuItem.Click += new System.EventHandler(this.pogramasToolStripMenuItem_Click);
            // 
            // somaToolStripMenuItem
            // 
            this.somaToolStripMenuItem.Name = "somaToolStripMenuItem";
            this.somaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.somaToolStripMenuItem.Text = "Soma";
            this.somaToolStripMenuItem.Click += new System.EventHandler(this.somaToolStripMenuItem_Click);
            // 
            // cálculoDeDescontoToolStripMenuItem
            // 
            this.cálculoDeDescontoToolStripMenuItem.Name = "cálculoDeDescontoToolStripMenuItem";
            this.cálculoDeDescontoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cálculoDeDescontoToolStripMenuItem.Text = "Cálculo de desconto";
            this.cálculoDeDescontoToolStripMenuItem.Click += new System.EventHandler(this.cálculoDeDescontoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // línguaNativaToolStripMenuItem
            // 
            this.línguaNativaToolStripMenuItem.Name = "línguaNativaToolStripMenuItem";
            this.línguaNativaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.línguaNativaToolStripMenuItem.Text = "Língua nativa";
            this.línguaNativaToolStripMenuItem.Click += new System.EventHandler(this.línguaNativaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoDeDescontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem línguaNativaToolStripMenuItem;
    }
}