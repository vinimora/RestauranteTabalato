using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace Restaurante
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

            
        }
       
        private void btnEntrarLog_Click(Object o, EventArgs e)
        {
            BLL.Login obj = new Login(); 
            string Usuario = txtLogin.Text; 
            string Senha = txtSenha.Text;
            bool resultadologin = false;
            obj.USUARIO1 = Usuario;  
            obj.SENHA1 = Senha;
            resultadologin = obj.Logar(); 

            
            if (resultadologin == true )
            {
                frmSistema frmSistema = new frmSistema();
               frmSistema.Show();
              this.Close();
            }
           else
            {
                MessageBox.Show("Usuario/Senha Incorretos !!");
            }
        }
        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarLog_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
            //MessageBox.Show(ClasseConexao.Conexao()); 
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void GainFocus(string textoAnterior, TextBox txt)
        {
            if (txt.Text == textoAnterior)
            {
                txt.Text = "";
            }

        }

        private void LostFocus(string textoAnterior, TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Text = textoAnterior;
                if (txt == txtSenha)
                {
                    txt.Multiline = true;
                }
            }
            
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            LostFocus("Digite seu login", txtLogin);
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            GainFocus("Digite seu login", txtLogin);
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            GainFocus("Digite sua senha", txtSenha);
            txtSenha.PasswordChar = '*';
            txtSenha.Multiline = false;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            LostFocus("Digite sua senha", txtSenha);
            txtSenha.PasswordChar = '*';
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}