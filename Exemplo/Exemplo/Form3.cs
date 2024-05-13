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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        double Desc;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pro, Reg, Result;

           Pro = Convert.ToDouble(txtProduto.Text);
           Reg = Convert.ToDouble(txtCodigo.Text);

            if (Reg == 1) {
                Desc = 5;
                txtRegiao.Text = "Norte";
            }
            else if (Reg == 2)
            {
                Desc = 15;
                txtRegiao.Text = "Sul";
            }
            else if (Reg == 3)
            {
                Desc = 7;
                txtRegiao.Text = "Sudeste";
            }
            else if(Reg == 4)
            {
                Desc = 12;
                txtRegiao.Text = "Nordeste";
            }
            else if(Reg == 5)
            {
                Desc = 20;
                txtRegiao.Text = "Centro-Oeste";
            }
            else
            {                
                txtRegiao.Text = "Importado.";
            }

            Result = Pro * (Desc / 100);

            txtResultado.Text = Result.ToString();
        }

        private void lblLista_Click(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu tela = new frmMenu();
            tela.Show();
        }

        private void txtRegiao_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
