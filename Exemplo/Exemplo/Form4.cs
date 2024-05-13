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
    public partial class frmLingua : Form
    {
        public frmLingua()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtLing_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cl;

            cl = Convert.ToDouble(txtCod.Text);
            

            if(cl == 1)
            {
                txtLing.Text = "Brasileiro";
            }
            else if(cl == 2)
            {
                txtLing.Text = "Alemão";
            }
            else if (cl == 3) 
            {
                txtLing.Text = "Inglês";
            }
            else if (cl == 4)
            {
                txtLing.Text = "Italiano";
            }
            else if (cl == 5) 
            {
                txtLing.Text = "Espanhol";
            }
            else if (cl == 6)
            {
                txtLing.Text = "Francês";
            }
            else
            {
                txtLing.Text = "A Língua nativa não pode ser apresentada.";
            }

            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu tela = new frmMenu();
            tela.Show();
        }
    }
}
