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
    public partial class frmsoma : Form
    {
        public frmsoma()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu tela = new frmMenu();
            tela.Show();
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            double N1, N2, R;

            N1 = Convert.ToDouble(txtNumero1.Text);
            N2 = Convert.ToDouble(txtNumero2.Text);

            R = N1 + N2;


        }
    }
}
