using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {        

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pogramasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsoma soma = new frmsoma();
            soma.Show();
        }

        private void cálculoDeDescontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduto produto = new frmProduto();
            produto.Show();
        }

        private void línguaNativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLingua lingua = new frmLingua();
            lingua.Show();
            
        }
    }
}
