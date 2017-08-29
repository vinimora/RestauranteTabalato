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
    public partial class telaCozinha : Form
    {
        public telaCozinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair desta tela?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
 //               frmSistema frmSistema = new frmSistema();
   //             frmSistema.ShowDialog();
                this.Close();
            }
        }
    }
}
