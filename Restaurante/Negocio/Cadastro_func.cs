using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

using System.Text.RegularExpressions;

namespace Restaurante
{
    public partial class frmCadastroFunc : Form
    {
        public frmCadastroFunc()
        {
            InitializeComponent();
        }

        private int ID = 0;
        private static OracleCommand cmd;
        private static string SQL;
        private static OracleConnection cn;
        private static string strConexaoOra = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521)))(CONNECT_DATA=(SID=xe)));User ID=TCC123;Password=123;";


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //DialogResult d = MessageBox.Show("finalizar cadastro? ", "Meu Sistema " + this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            BLL.Funcionario func = new BLL.Funcionario();


            func.Sobrenome = txtSobrenome.Text;
            func.Estado = txtUF.Text;
            func.Bairro = txtBairro.Text;
            func.Celular = txtCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            func.Cep = txtCEP.Text.Replace("-", "");
            func.Cidade = txtCidade.Text;
            func.Funcao = cbxIdCargo.SelectedItem.ToString();
            func.Complemento = txtComp.Text;
            func.Cpf = txtCPF.Text.Replace(",", "").Replace(",", "").Replace("-", "");
            func.Email = txtEmail.Text;
            func.rua = txtRua.Text;
            func.Nome = txtNome.Text;
            func.Rg = txtRG.Text;
            func.numero = txtN.Text;
            func.Telefone = txtTel.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            func.Cargo = cbxCargo.SelectedItem.ToString();
            func.Datanasc = mktDtNasc.Text;
            func.Datacad = mktDtCad.Text;
            func.Endereço = gbEndereco.Text;


            func.Incluir();

            //  cmd.ExecuteNonQuery();

            // cn.Close();
            MessageBox.Show("Inserido com Sucesso");

            // MessageBox.Show(ex.Message);



        }

        private void Limpar()
        {
            txtBairro.Text = "";
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtcod.Text = "";
            txtComp.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtN.Text = "";
            txtNome.Text = "";
            txtRG.Text = "";
            //txtRua.Text = "";
            //txtSalario.Text = "";
            txtTel.Text = "";
            txtUF.Text = "";
            cbxCargo.SelectedItem = "";

            ID = 0;
        }

        private void LimparDados(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Você tem certeza?", "Sair do " + this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                txtBairro.Clear();
                txtCelular.Clear();
                txtCEP.Clear();
                txtCidade.Clear();
                txtcod.Clear();
                txtComp.Clear();
                txtCPF.Clear();
                txtEmail.Clear();
                txtN.Clear();
                txtNome.Clear();
                txtRG.Clear();
                txtRua.Clear();
                //txtSalario.Clear();
                txtTel.Clear();
                txtUF.Clear();
                txtSobrenome.Clear();
                cbxCargo.SelectedItem = "";
            }

        }
        private void ExibirDados()
        {
            string oradb = strConexaoOra;
            cn = new OracleConnection(oradb);
            cn.Open();
            SQL = "SELECT * FROM CADASTRO_FUNCIONARIOS ";
            OracleCommand oc = new OracleCommand(SQL, cn);
            oc.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(oc);

            da.Fill(dt);

            dgvListaFuncionarios.DataSource = dt;
            cn.Close();
        }
        private void Alterar(object o, EventArgs e)
        {
            try
            {
                if (txtNome.Text != "" && txtCelular.Text != "" && txtBairro.Text != "" && cbxCargo.Text != "" && txtCEP.Text != "" && txtCidade.Text != "" && txtcod.Text != "" && txtComp.Text != "" && txtCPF.Text != "" && txtEmail.Text != "" && txtN.Text != "" && txtRG.Text != "" && txtTel.Text != "" && txtUF.Text != "")
            {
                BLL.Funcionario funcAlt = new BLL.Funcionario();
                funcAlt.alterar();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                
                throw;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {

                // SQL = "";
                SQL = "DELETE FROM CADASTRO_FUNCIONARIOS ";
                SQL += "WHERE ID_FUNCIONARIO = " + dgvListaFuncionarios.CurrentRow.Cells[0].Value.ToString();
                cn.Open();
                OracleCommand oc = new OracleCommand(SQL, cn);
                oc.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(oc);
                oc.ExecuteNonQuery();
                //cn.Close();


            }
            catch (Exception)
            {

                throw;
            }


















            /*
            BLL.Funcionario func = new BLL.Funcionario();           
               if (ID != 0)
            {
                string oradb = strConexaoOra;
                cn = new OracleConnection(oradb);
                cn.Open();
                SQL = "DELETE FROM cadastro_funcionarios WHERE ID_FUNCIONARIO = '" + ID + "'";
                cmd = new OracleCommand(SQL, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                ExibirDados();
                Limpar();
                MessageBox.Show("Deletado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um registro para ser apagado.");
            }*/
        }



        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void Cod_Click(object sender, EventArgs e)
        {

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDataCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar o cadastro e sair desta tela?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
//                frmSistema frmSistema = new frmSistema();
  //              frmSistema.ShowDialog();
    //            this.Visible = false;
                this.Close();

            }
        }

        private void dgvListaFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvListaFuncionarios.DefaultCellStyle.Font = new Font("Tahoma", 15);
            this.dgvListaFuncionarios.DefaultCellStyle.ForeColor = Color.Black;      
            frmCadastroFunc cadastro_func = new frmCadastroFunc();
            ExibirDados();
        }
        private void btnListarFuncionarios_Click(object sender, EventArgs e)
        {
            string oradb = strConexaoOra;
            cn = new OracleConnection(oradb);
            cn.Open();
            SQL = "SELECT * FROM CADASTRO_FUNCIONARIOS";
            ExibirDados();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblf_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        //VALIDAÇÕES DE APENAS NUMERO!!!
        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtRG.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("APENAS NUMEROS ", "ATENÇÃO!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("APENAS LETRAS ", "ATENÇÃO!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.CharacterCasing = CharacterCasing.Upper;
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string oradb = strConexaoOra;
            cn = new OracleConnection(oradb);
            SQL = "ALTER TABLE CADASTRO_FUNCIONARIOS";
            //  Alterar();
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void txtRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblRG_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void cbxIdCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroFunc_Load(object sender, EventArgs e)
        {
            txtcod.Text = BLL.Funcionario.buscarId().ToString();
            btnAlterar2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BLL.Funcionario.buscarId().ToString());
            txtcod.Text = BLL.Funcionario.buscarId().ToString();
        }

        private void dgvListaFuncionarios_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*try
            {
                SQL += "DELETE * FROM CADASTRO_FUNCIONARIOS "; 
                SQL += "WHERE ID_FUNCIONARIO = " + dgvListaFuncionarios.CurrentRow.Cells[0].Value;
                cn.Open();
              SQL cd 
            }
            catch (Exception)
            {
                
                throw;
            }
            
            
            
            
            int Linha = dgvListaFuncionarios.CurrentRow.Index;
            int Codigo = int.Parse(dgvListaFuncionarios.Rows[Linha].Cells[0].ToString());
            
            
            
             BLL.Funcionario func = new BLL.Funcionario();
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtUF.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString()= txtBairro.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "");
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString()= txtCEP.Text.Replace("-", "");
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtCidade.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = cbxIdCargo.SelectedItem.ToString();
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString()= txtComp.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtCPF.Text.Replace(",", "").Replace(",", "").Replace("-", "");
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString()= txtEmail.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtRua.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtNome.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtRG.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtN.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = txtTel.Text.Replace("(", "").Replace(")", "").Replace("-", "");
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = cbxCargo.SelectedItem.ToString();
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = mktDtNasc.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = mktDtCad.Text;
                 this.dgvListaFuncionarios.CurrentRow.Cells[].Value.ToString() = gbEndereco.Text;
            */

        }

        private void dgvListaFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvListaFuncionarios.CurrentRow.Cells[0].Value);
            txtNome.Text = dgvListaFuncionarios.CurrentRow.Cells[1].Value.ToString();                           
            txtSobrenome.Text = dgvListaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtRG.Text = dgvListaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtCPF.Text = dgvListaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            if (dgvListaFuncionarios.CurrentRow.Cells[5].ToString() == "M")
            {
                radioButton1.Checked= true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            mktDtNasc.Text = dgvListaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            txtRua.Text = dgvListaFuncionarios.CurrentRow.Cells[7].Value.ToString();
            txtN.Text = dgvListaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtComp.Text = dgvListaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = dgvListaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = dgvListaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtUF.Text = dgvListaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtCEP.Text = dgvListaFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtTel.Text = dgvListaFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtCelular.Text = dgvListaFuncionarios.CurrentRow.Cells[15].Value.ToString();
            txtEmail.Text = dgvListaFuncionarios.CurrentRow.Cells[16].Value.ToString();
            cbxIdCargo.SelectedItem = dgvListaFuncionarios.CurrentRow.Cells[17].Value.ToString();
            mktDtCad.Text = dgvListaFuncionarios.CurrentRow.Cells[18].Value.ToString();
            btnAlterar2.Visible = true;
            btnCadastrar.Visible = false;
        }

        private void btnAlterar2_Click(object sender, EventArgs e)
        {


            //DialogResult d = MessageBox.Show("finalizar cadastro? ", "Meu Sistema " + this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            BLL.Funcionario func = new BLL.Funcionario();


            func.IdFunci1 = ID;
            func.Estado = txtUF.Text;
            func.Bairro = txtBairro.Text;
            func.Celular = txtCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            func.Cep = txtCEP.Text.Replace("-", "");
            func.Cidade = txtCidade.Text;
            func.Funcao = cbxIdCargo.Text;
            func.Complemento = txtComp.Text;
            func.Cpf = txtCPF.Text.Replace(",", "").Replace(",", "").Replace("-", "");
            func.Email = txtEmail.Text; 
            func.Nome = txtNome.Text;
            func.Rg = txtRG.Text;
            func.numero = txtN.Text;
            func.Telefone = txtTel.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            func.Datanasc = mktDtNasc.Text;
            func.Datacad = mktDtCad.Text;
            func.Sobrenome = txtSobrenome.Text;
            func.Endereço = txtRua.Text;
            if (radioButton1.Checked == true)
            {
                func.Sexo = "M";
            }else{
                func.Sexo = "F";
            }
            func.alterar();

            MessageBox.Show("Alterado com sucesso!");
        }

        private void gbContato_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BLL.Funcionario func = new BLL.Funcionario();

            func.Usuario = txtUsuario.Text;
            func.Senha = txtSenha.Text;

            func.IdFunci = Convert.ToInt32(txtcod.Text);

            func.IncluirLogin();

            MessageBox.Show("Inserido com Sucesso !");
        }

        private void txtcod_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}



