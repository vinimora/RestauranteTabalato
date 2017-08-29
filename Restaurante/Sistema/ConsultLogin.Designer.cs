namespace Restaurante.Sistema
{
    partial class ConsultLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultLogin));
            this.dgvConsultaFunc = new System.Windows.Forms.DataGridView();
            this.btnListarFuncionarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaFunc
            // 
            this.dgvConsultaFunc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvConsultaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFunc.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaFunc.Name = "dgvConsultaFunc";
            this.dgvConsultaFunc.Size = new System.Drawing.Size(346, 166);
            this.dgvConsultaFunc.TabIndex = 0;
            this.dgvConsultaFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListarFuncionarios
            // 
            this.btnListarFuncionarios.BackColor = System.Drawing.Color.Silver;
            this.btnListarFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarFuncionarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.btnListarFuncionarios.Location = new System.Drawing.Point(12, 184);
            this.btnListarFuncionarios.Name = "btnListarFuncionarios";
            this.btnListarFuncionarios.Size = new System.Drawing.Size(160, 41);
            this.btnListarFuncionarios.TabIndex = 65;
            this.btnListarFuncionarios.Text = "Listar Login";
            this.btnListarFuncionarios.UseVisualStyleBackColor = false;
            this.btnListarFuncionarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(198, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 66;
            this.button1.Text = "Alterar Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ConsultLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(375, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListarFuncionarios);
            this.Controls.Add(this.dgvConsultaFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Login";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaFunc;
        internal System.Windows.Forms.Button btnListarFuncionarios;
        internal System.Windows.Forms.Button button1;
    }
}