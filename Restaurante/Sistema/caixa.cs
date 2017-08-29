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
    public partial class frmCaixa : Form
    {
        string[] numeroMesa = new string[2];
        string[] nomeProduto = new string[2];
        decimal[] valorProduto = new decimal[2];
        decimal somaTotal;
        
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void loadProducts()
        {
            numeroMesa[1] = "01";
            numeroMesa[2] = "02";
            numeroMesa[3] = "03";

            nomeProduto[1] = "Temaki";
            nomeProduto[2] = "sushi";
            nomeProduto[3] = "arroz";
           

            valorProduto[1] = 12.50M;
            valorProduto[2] = 13.50M;
            valorProduto[3] = 11.50M;
        
        
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnfecha_venda_Click(object sender, EventArgs e)
        {

           this.Close(); 
        }

        private void lblnum_mesa_Click(object sender, EventArgs e)
        {

        }

        private void btnDeb_Val_Click(object sender, EventArgs e)
        {

        }

        private void txtNumMesa_TextChanged(object sender, EventArgs e)
        {
            if (txtNumMesa.Text.Length == 2)
            {
                int ind = 0;
                for (int cp = 1; cp < 6; cp++)
                {
                    if (txtNumMesa.Text == nomeProduto[cp])
                    {
                        ind = cp;
                    }
                }
                if (ind > 0)
                {
                    lvPedidos.Items.Add(String.Format("#{0} - {1} - {2}", numeroMesa[ind], nomeProduto[ind], valorProduto[ind]));
                    somaTotal += valorProduto[ind];
                    txtValorTotal.Text = Convert.ToString(somaTotal);
                
                }
                else
                {
                    MessageBox.Show("Produto nao encontrado");
                }
            }
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            loadProducts();
            somaTotal = 0 ;
        }
    }
}




























