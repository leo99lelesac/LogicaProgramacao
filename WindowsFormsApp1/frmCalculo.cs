using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

       

        

        private void btnSomar_Click(object sender, EventArgs e)
        {

            if (txtn1Somar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o campo número 1 da soma");
                txtn1Somar.Focus();
                txtn1Somar.Clear();
            }

            else if (txtN2Somar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o campo número 2 da soma");
                txtN2Somar.Focus();
                txtN2Somar.Clear();

            }

            else
            {
                double numero1, numero2, resultado;

                try
                {

                    numero1 = Convert.ToDouble(txtn1Somar.Text);
                    numero2 = Convert.ToDouble(txtN2Somar.Text);

                    resultado = numero1 + numero2;

                    txtResultadoSomar.Text = Convert.ToString(resultado);
                }
                catch 
                {
                    MessageBox.Show( "digite os nhumeros corretamentes " );
                }

               


            }

          

        }
    }
}
