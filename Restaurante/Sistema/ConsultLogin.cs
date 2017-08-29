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

namespace Restaurante.Sistema
{
    public partial class ConsultLogin : Form
    {
        public ConsultLogin()
        {
            InitializeComponent();
        }

        private int ID = 0;
        private static OracleCommand cmd;
        private static string SQL;
        private static OracleConnection cn;
        private static string strConexaoOra = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521)))(CONNECT_DATA=(SID=xe)));User ID=sys;Password=123456;DBA Privilege=SYSDBA;";
        private void button1_Click(object sender, EventArgs e)
        {
            ExibirLog();
        }

        private void ExibirLog()
        {
            string oradb = strConexaoOra;
            cn = new OracleConnection(oradb);
            cn.Open();
            SQL = "SELECT * FROM LOGIN_FUNC ";
            OracleCommand oc = new OracleCommand(SQL, cn);
            oc.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(oc);

            da.Fill(dt);

            dgvConsultaFunc.DataSource = dt;
            cn.Close();
        }
        
        
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConsultLogin consultaLog = new ConsultLogin();
            string oradb = strConexaoOra;
            cn = new OracleConnection(oradb);
            cn.Open();
            SQL = "SELECT * FROM LOGIN_FUNC";
            ExibirLog();
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AlteraLoguin AlteraLOg = new AlteraLoguin();
            AlteraLOg.Show();
            this.Visible = true;
        }
    }
}
