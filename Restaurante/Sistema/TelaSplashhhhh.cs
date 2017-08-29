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
    public partial class TelaSplashhhhh : Form
    {
        public TelaSplashhhhh()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            label1.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                timer1.Enabled = false;
                
                timer2.Enabled = true;
                timer2.Start();
            }

              
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Visible = false;
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
        
    }
}
