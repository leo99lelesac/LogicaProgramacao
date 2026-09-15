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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("preencher o campo nome");
                txtNome.Focus();
                txtNome.Clear();
            }

            else if (txtRua.Text.Trim() == string.Empty)
            {

                MessageBox.Show("preencher o campo rua");
                txtRua.Focus();
                txtRua.Clear();

            }
            else if (txtBairro.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o campo bairro");
                txtBairro.Focus();
                txtBairro.Clear();
            }
            else
            {
                string nome;
                string rua;
                string bairro;

                nome = txtNome.Text;
                rua = txtRua.Text;
                bairro = txtBairro.Text;


                MessageBox.Show(" Nome digitado " + nome +  "\n sua rua : " + rua + " \n seu bairro : " + bairro);
            }

        }
    }
}
