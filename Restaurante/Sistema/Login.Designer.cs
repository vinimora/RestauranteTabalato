namespace Restaurante
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCancelarLog = new System.Windows.Forms.Button();
            this.btnEntrarLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(40, 133);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(271, 32);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Tag = "";
            this.txtLogin.Text = "Digite seu login";
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(40, 205);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(271, 35);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Digite sua senha";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // btnCancelarLog
            // 
            this.btnCancelarLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLog.Location = new System.Drawing.Point(12, 283);
            this.btnCancelarLog.Name = "btnCancelarLog";
            this.btnCancelarLog.Size = new System.Drawing.Size(131, 66);
            this.btnCancelarLog.TabIndex = 2;
            this.btnCancelarLog.Text = "Cancelar";
            this.btnCancelarLog.UseVisualStyleBackColor = true;
            this.btnCancelarLog.Click += new System.EventHandler(this.btnCancelarLog_Click);
            // 
            // btnEntrarLog
            // 
            this.btnEntrarLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLog.Location = new System.Drawing.Point(209, 283);
            this.btnEntrarLog.Name = "btnEntrarLog";
            this.btnEntrarLog.Size = new System.Drawing.Size(131, 66);
            this.btnEntrarLog.TabIndex = 3;
            this.btnEntrarLog.Text = "Entrar";
            this.btnEntrarLog.UseVisualStyleBackColor = true;
            this.btnEntrarLog.Click += new System.EventHandler(this.btnEntrarLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrarLog);
            this.Controls.Add(this.btnCancelarLog);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCancelarLog;
        private System.Windows.Forms.Button btnEntrarLog;
        private System.Windows.Forms.Label label1;
    }
}

