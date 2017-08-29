using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurante.Sistema
{
    public partial class AlteraLoguin : Form
    {
       
        public AlteraLoguin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void AlterarLoguin(object o, EventArgs e)
        {
            try
            {
                if (txtAlterarUsuario.Text != "" && txtAlterarSenha.Text != "")
                {
                    BLL.Login funcAltlog = new BLL.Login();
                    funcAltlog.AlteraLoguin();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
              //  throw;
            }       
          
             
        }
    }
}
