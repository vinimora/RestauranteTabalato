using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                 frmCaixa caixa = new frmCaixa();
            caixa.Show();
            this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                
               // throw;
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroFunc Cadastro_func= new frmCadastroFunc();
                Cadastro_func.Show();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
               // throw;
            }
        }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("O sistema será encerrado, você tem certeza?", " ATENÇÃO!!! "+ this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
            

        }

        private void cozinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.telaCozinha telaCozinha = new Sistema.telaCozinha();
            telaCozinha.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmSistema_Load(object sender, EventArgs e)
        {

        }

        private void cONSULTADELOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.ConsultLogin ConsultLogin = new Sistema.ConsultLogin();
            ConsultLogin.Show();
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                  Sistema.telaCozinha telaCozinha = new Sistema.telaCozinha();
            telaCozinha.Show();
            this.Visible = true;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
               // throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastroFunc Cadastro_func = new frmCadastroFunc();
            Cadastro_func.Show();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCaixa caixa = new frmCaixa();
            caixa.Show();
            this.Visible = true;
        }

        private void btnBuscarLogin_Click(object sender, EventArgs e)
        {
            Sistema.ConsultLogin ConsultLogin = new Sistema.ConsultLogin();
            ConsultLogin.Show();
            this.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
