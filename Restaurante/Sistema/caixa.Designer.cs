namespace Restaurante
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.lblValortot = new System.Windows.Forms.Label();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.txtNumMesa = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnBuscarMesa = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCPFcaixa = new System.Windows.Forms.Label();
            this.mtbCPFcaixa = new System.Windows.Forms.MaskedTextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblValorDebito = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtValorDebito = new System.Windows.Forms.TextBox();
            this.btnDebitarValor = new System.Windows.Forms.Button();
            this.lvPedidos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblValortot
            // 
            this.lblValortot.AutoSize = true;
            this.lblValortot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblValortot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValortot.Location = new System.Drawing.Point(352, 75);
            this.lblValortot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValortot.Name = "lblValortot";
            this.lblValortot.Size = new System.Drawing.Size(88, 19);
            this.lblValortot.TabIndex = 1;
            this.lblValortot.Text = "Valor Total:";
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumMesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumMesa.Location = new System.Drawing.Point(38, 30);
            this.lblNumMesa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(126, 19);
            this.lblNumMesa.TabIndex = 3;
            this.lblNumMesa.Text = "Numero da Mesa";
            this.lblNumMesa.Click += new System.EventHandler(this.lblnum_mesa_Click);
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.Location = new System.Drawing.Point(174, 30);
            this.txtNumMesa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.Size = new System.Drawing.Size(46, 26);
            this.txtNumMesa.TabIndex = 4;
            this.txtNumMesa.TextChanged += new System.EventHandler(this.txtNumMesa_TextChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderSize = 2;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletar.Location = new System.Drawing.Point(42, 297);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(145, 34);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar item";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMesa
            // 
            this.btnBuscarMesa.FlatAppearance.BorderSize = 2;
            this.btnBuscarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMesa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarMesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarMesa.Location = new System.Drawing.Point(197, 297);
            this.btnBuscarMesa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarMesa.Name = "btnBuscarMesa";
            this.btnBuscarMesa.Size = new System.Drawing.Size(145, 34);
            this.btnBuscarMesa.TabIndex = 6;
            this.btnBuscarMesa.Text = "Buscar Mesa";
            this.btnBuscarMesa.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(528, 72);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(148, 26);
            this.txtValorTotal.TabIndex = 8;
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormaPag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormaPag.Location = new System.Drawing.Point(352, 115);
            this.lblFormaPag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(166, 38);
            this.lblFormaPag.TabIndex = 9;
            this.lblFormaPag.Text = "Forma de pagamento: *\r\n\r\n";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Cartão Crédito",
            "Cartão Débito",
            "Dinheiro",
            "Vale Refeição",
            "Divisão de Valores\t\t\t\t\t"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(528, 115);
            this.cbFormaPagamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(148, 27);
            this.cbFormaPagamento.TabIndex = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(528, 297);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(145, 34);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnfecha_venda_Click);
            // 
            // lblCPFcaixa
            // 
            this.lblCPFcaixa.AutoSize = true;
            this.lblCPFcaixa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCPFcaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPFcaixa.Location = new System.Drawing.Point(352, 153);
            this.lblCPFcaixa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCPFcaixa.Name = "lblCPFcaixa";
            this.lblCPFcaixa.Size = new System.Drawing.Size(38, 19);
            this.lblCPFcaixa.TabIndex = 12;
            this.lblCPFcaixa.Text = "CPF";
            // 
            // mtbCPFcaixa
            // 
            this.mtbCPFcaixa.Location = new System.Drawing.Point(528, 153);
            this.mtbCPFcaixa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtbCPFcaixa.Mask = "000.000.000-00";
            this.mtbCPFcaixa.Name = "mtbCPFcaixa";
            this.mtbCPFcaixa.Size = new System.Drawing.Size(148, 26);
            this.mtbCPFcaixa.TabIndex = 13;
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorPago.Location = new System.Drawing.Point(352, 194);
            this.lblValorPago.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(87, 19);
            this.lblValorPago.TabIndex = 14;
            this.lblValorPago.Text = "Valor Pago:";
            // 
            // lblValorDebito
            // 
            this.lblValorDebito.AutoSize = true;
            this.lblValorDebito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorDebito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorDebito.Location = new System.Drawing.Point(352, 239);
            this.lblValorDebito.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValorDebito.Name = "lblValorDebito";
            this.lblValorDebito.Size = new System.Drawing.Size(123, 19);
            this.lblValorDebito.TabIndex = 15;
            this.lblValorDebito.Text = "Valor em Débito:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(528, 194);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(148, 26);
            this.txtValorPago.TabIndex = 16;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(528, 239);
            this.txtValorDebito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(148, 26);
            this.txtValorDebito.TabIndex = 17;
            // 
            // btnDebitarValor
            // 
            this.btnDebitarValor.FlatAppearance.BorderSize = 2;
            this.btnDebitarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebitarValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDebitarValor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDebitarValor.Location = new System.Drawing.Point(373, 297);
            this.btnDebitarValor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDebitarValor.Name = "btnDebitarValor";
            this.btnDebitarValor.Size = new System.Drawing.Size(145, 34);
            this.btnDebitarValor.TabIndex = 18;
            this.btnDebitarValor.Text = "Debitar Valor";
            this.btnDebitarValor.UseVisualStyleBackColor = true;
            this.btnDebitarValor.Click += new System.EventHandler(this.btnDeb_Val_Click);
            // 
            // lvPedidos
            // 
            this.lvPedidos.Location = new System.Drawing.Point(42, 64);
            this.lvPedidos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvPedidos.Name = "lvPedidos";
            this.lvPedidos.Size = new System.Drawing.Size(300, 225);
            this.lvPedidos.TabIndex = 2;
            this.lvPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(704, 364);
            this.Controls.Add(this.btnDebitarValor);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.lblValorDebito);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.mtbCPFcaixa);
            this.Controls.Add(this.lblCPFcaixa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnBuscarMesa);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtNumMesa);
            this.Controls.Add(this.lblNumMesa);
            this.Controls.Add(this.lvPedidos);
            this.Controls.Add(this.lblValortot);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValortot;
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.TextBox txtNumMesa;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnBuscarMesa;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCPFcaixa;
        private System.Windows.Forms.MaskedTextBox mtbCPFcaixa;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblValorDebito;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtValorDebito;
        private System.Windows.Forms.Button btnDebitarValor;
        private System.Windows.Forms.ListView lvPedidos;
    }
}