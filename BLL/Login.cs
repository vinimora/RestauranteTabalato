using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace BLL
{
   public  class Login
    {
        private static OracleConnection cn;
        private static OracleCommand cmd;
        private static OracleDataAdapter da;
        private static OracleDataReader dr;
        private static OracleParameter p;
        private static OracleParameter q;
        private static DataSet ds;
        private static string SQL;
        private static string dado;
        private static DataTable dt;

        private string ID_FUNC;

        public string ID_FUNC1
        {
            get { return ID_FUNC; }
            set { ID_FUNC = value; }
        }
        private string USUARIO;

        public string USUARIO1
        {
            get { return USUARIO; }
            set { USUARIO = value; }
        }
        private string SENHA;

        public string SENHA1
        {
            get { return SENHA; }
            set { SENHA = value; }
        }
        private string NIVEL_ACESSO;

        public string NIVEL_ACESSO1
        {
            get { return NIVEL_ACESSO; }
            set { NIVEL_ACESSO = value; }
        }
        private string STATUS_LOGIN;

        public string STATUS_LOGIN1
        {
            get { return STATUS_LOGIN; }
            set { STATUS_LOGIN = value; }
        }
        public bool Logar()
        {

            ClasseConexao objConexao = new ClasseConexao();
            SQL = "SELECT SENHA, USUARIO, NIVEL_ACESSO,STATUS_LOGIN FROM LOGIN_FUNC WHERE STATUS_LOGIN=1 AND NIVEL_ACESSO=1 AND USUARIO='" + USUARIO1 + "' AND SENHA='" + SENHA1 + "'";
            dr = objConexao.RetornarDataReader(SQL);
            dr.Read();
            if (dr.HasRows) //dr.Read()
            {
             

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AlteraLoguin() { 
      
            
            
            
            
            ClasseConexao c = new ClasseConexao();
           SQL ="UPDATE login_func SET SENHA = '" + SENHA1 + "' WHERE USUARIO = '" + USUARIO1 + "'";       
           dr = c.RetornarDataReader(SQL);
            dr.Read();
            if (dr.HasRows) //dr.Read()
            {
             

             return true;
            }
            else
            {
                return false;
            }
        }

   
           }
    }

