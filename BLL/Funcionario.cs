using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
namespace BLL
{
    public class Funcionario
    {

        private static OracleConnection cn;
        private static OracleCommand cmd;
        private static OracleDataAdapter da;
        private static OracleDataReader dr;
        private static OracleParameter p;
        private static DataSet ds;
        private static DataTable dt;



        public string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string _Senha;

        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        public int _IdFunci;

        public int IdFunci1
        {
            get { return _IdFunci; }
            set { _IdFunci = value; }
        }
        public string _sobrenome;

        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        public string _rg;

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }
        public string _cpf;

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public string _sexo;

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public string _datanasc;

        public string Datanasc
        {
            get { return _datanasc; }
            set { _datanasc = value; }
        }
        public string _cidade;

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string _endereço;

        public string Endereço
        {
            get { return _endereço; }
            set { _endereço = value; }
        }
        public string _complemento;

        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }
        public string _cep;

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }
        public string _bairro;

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        public string _celular;

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
        public string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string _funcao;

        public string Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }
        public double _salario;

        public double Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }
        public string _datacad;

        public string Datacad
        {
            get { return _datacad; }
            set { _datacad = value; }
        }
        public string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int _StatusFunci;
        public byte _Ativo;



        //private static DataSet ds;
        private static string SQL;
        public string strComSQL;
        public byte Ativo
        {
            get
            {
                return _Ativo;
            }
            set
            {
                _Ativo = value;
            }
        }
        public int IdFunci
        {
            get
            {
                return _IdFunci;
            }
            set
            {
                _IdFunci = value;
            }

        }
        public int StatusFunci
        {
            get
            {
                return _StatusFunci;
            }
            set
            {
                _StatusFunci = value;
            }

        }
        public string _rua;


        public string rua
        {
            get
            {
                return _rua;
            }
            set
            {
                _rua = value;
            }

        }

        public string _numero;


        public string numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }

        }

        public string Cargo;


        public string _Cargo
        {
            get
            {
                return _Cargo;
            }
            set
            {
                _Cargo = value;
            }

        }




        public void Incluir()
        {
            try
            {

              // OracleConnection c = new OracleConnection();

                ClasseConexao c = new ClasseConexao();
                
                SQL = "INSERT INTO sys.cadastro_funcionarios(ID_FUNCIONARIO,NOME,SOBRENOME,RG,CPF,SEXO,DATA_NASC,endereco,NUM_RESID,COMPLEMENTO,BAIRRO,CIDADE,ESTADO,CEP,TELEFONE,CELULAR,EMAIL, id_cargo, data_cadastro)"+
                "VALUES(SEQ_ID_FUNC.NEXTVAL,'" + Nome + "','" + Sobrenome + "','" + Rg + "','" + Cpf + "','" + Sexo + "','" + Datanasc + "','" + Endereço + "','" + numero + "','" + Complemento + "','" + Bairro + "','" + Cidade + "','" + Estado + "','" + Cep + "'," + Telefone + ", "+Celular+",'" + Email + "'," + Funcao + ",'" + Datacad + "')";
                c.ExecutarComando(SQL);

                /* strComSQL = ("INSERT INTO TCC123.cadastro_funcionarios VALUES(SEQ_ID_FUNC.NEXTVAL,'");
                 strComSQL += ("'" + Nome + "','");
                 strComSQL += ("'" + Sobrenome + "','");
                 strComSQL += ("'" + Rg + "','");
                 strComSQL += ("'" + Cpf + "','");
                 strComSQL += ("'" + Sexo + "','");
                 strComSQL += ("'" + Datanasc + "','");
                 strComSQL += ("'" + Endereço + "','");
                 strComSQL += ("'" + numero + "','");
                 strComSQL += ("'" + Complemento + "','");
                 strComSQL += ("'" + Cidade + "','");
                 strComSQL += ("'" + Estado + "','");
                 strComSQL += ("'" + Cep + "','");
                 strComSQL += ("'" + Telefone + "','");
                 strComSQL += ("'" + Celular + "','");
                 strComSQL += ("'" + Email + "','");
                 strComSQL += ("'" + Funcao + "','");

                 strComSQL += ("'" + Datacad + "')'");*/
                // c.ExecutarComando(strComSQL);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IncluirLogin()
        {
            try
            {

                // OracleConnection c = new OracleConnection();

                ClasseConexao c = new ClasseConexao();

                SQL = "INSERT INTO LOGIN_FUNC VALUES("+IdFunci+",'"+Usuario+"','"+Senha+"',1,1)";
                c.ExecutarComando(SQL);

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void alterar()
        {
                ClasseConexao c = new ClasseConexao();
                SQL = "UPDATE CADASTRO_FUNCIONARIOS SET NOME = '" + Nome + "',SOBRENOME = '" + Sobrenome + "',RG = '" + Rg + "',CPF = '" + Cpf + "',SEXO = '" + Sexo + "',DATA_NASC = '" + Datanasc  + "',ENDERECO = '" + Endereço + "',NUM_RESID= '" + numero + "',COMPLEMENTO= '" + Complemento + "',BAIRRO= '" + Bairro + "',CIDADE= '" + Cidade + "',ESTADO= '" + Estado + "',CEP = '" + Cep + "',TELEFONE = " + Telefone + ",CELULAR = " + Celular + ",EMAIL= '" + Email + "',ID_CARGO = " + Funcao + ",DATA_CADASTRO = '" + Datacad + "' WHERE ID_FUNCIONARIO = " + IdFunci1 + "";
               /*strComSQL = ("UPDATE  TCC123.cadastro_funcionarios set ");
                strComSQL += ("'" + Nome + "','");
                strComSQL += ("'" + Sobrenome + "','");
                strComSQL += ("'" + Rg + "','");
                strComSQL += ("'" + Cpf + "','");
                strComSQL += ("'" + Sexo + "','");
                strComSQL += ("'" + Datanasc + "','");
                strComSQL += ("'" + Endereço + "','");
                strComSQL += ("'" + numero + "','");
                strComSQL += ("'" + Complemento + "','");
                strComSQL += ("'"+"'")
                strComSQL += ("'" + Cidade + "','");
                strComSQL += ("'" + Estado + "','");
                strComSQL += ("'" + Cep + "','");
                strComSQL += ("'" + Telefone + "','");
                strComSQL += ("'" + Email + "','");
                strComSQL += ("'" + Funcao + "','");
                strComSQL += ("'" + Datacad + "'");
                strComSQL += ("where ID_FUNCIONARIO = '" + IdFunci + "'"); */

                c.ExecutarComando(SQL);

        }

        public static int buscarId()
        {
            int i = 0;
            SQL = "SELECT MAX(ID_FUNCIONARIO) IDFUNCIONARIO FROM CADASTRO_FUNCIONARIOS";

            ClasseConexao c = new ClasseConexao();
            dr = c.RetornarDataReader(SQL);

            if (dr.Read())
            {
                return dr.GetInt32(0) + 1;
            }
            return i;

        }


    }

}
