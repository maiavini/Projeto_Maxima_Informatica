
namespace Projeto_Maxima_Informatica
{
    partial class FormDBConfig
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNomeBD = new System.Windows.Forms.TextBox();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUtilizador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAttachDB = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIntegrated = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabPageServer.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageServer);
            this.tabMain.Controls.Add(this.tabPageLocal);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(485, 502);
            this.tabMain.TabIndex = 11;
            // 
            // tabPageServer
            // 
            this.tabPageServer.Controls.Add(this.panel3);
            this.tabPageServer.Location = new System.Drawing.Point(4, 25);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServer.Size = new System.Drawing.Size(477, 473);
            this.tabPageServer.TabIndex = 0;
            this.tabPageServer.Text = "Servidor";
            this.tabPageServer.UseVisualStyleBackColor = true;
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.Controls.Add(this.panel2);
            this.tabPageLocal.Location = new System.Drawing.Point(4, 25);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocal.Size = new System.Drawing.Size(477, 473);
            this.tabPageLocal.TabIndex = 1;
            this.tabPageLocal.Text = "Arquivo Local";
            this.tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 99);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkIntegrated);
            this.panel2.Controls.Add(this.txtAttachDB);
            this.panel2.Controls.Add(this.txtDataSource);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTimeout);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 467);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNomeBD);
            this.panel3.Controls.Add(this.txtInstancia);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtUtilizador);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 467);
            this.panel3.TabIndex = 0;
            // 
            // txtNomeBD
            // 
            this.txtNomeBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeBD.Location = new System.Drawing.Point(169, 130);
            this.txtNomeBD.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeBD.Multiline = true;
            this.txtNomeBD.Name = "txtNomeBD";
            this.txtNomeBD.Size = new System.Drawing.Size(215, 34);
            this.txtNomeBD.TabIndex = 36;
            // 
            // txtInstancia
            // 
            this.txtInstancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInstancia.Location = new System.Drawing.Point(169, 62);
            this.txtInstancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstancia.Multiline = true;
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(215, 34);
            this.txtInstancia.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Password";
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUtilizador.Location = new System.Drawing.Point(169, 198);
            this.txtUtilizador.Margin = new System.Windows.Forms.Padding(4);
            this.txtUtilizador.Multiline = true;
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.Size = new System.Drawing.Size(215, 34);
            this.txtUtilizador.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Utilizador";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(169, 265);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(215, 34);
            this.txtPassword.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nome BD";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Instancia SQL";
            // 
            // txtAttachDB
            // 
            this.txtAttachDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAttachDB.Location = new System.Drawing.Point(203, 126);
            this.txtAttachDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttachDB.Multiline = true;
            this.txtAttachDB.Name = "txtAttachDB";
            this.txtAttachDB.Size = new System.Drawing.Size(215, 34);
            this.txtAttachDB.TabIndex = 44;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataSource.Location = new System.Drawing.Point(203, 58);
            this.txtDataSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataSource.Multiline = true;
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(215, 34);
            this.txtDataSource.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Connect Timeout";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimeout.Location = new System.Drawing.Point(203, 261);
            this.txtTimeout.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeout.Multiline = true;
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(215, 34);
            this.txtTimeout.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Attach Db Filename";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Data Source";
            // 
            // chkIntegrated
            // 
            this.chkIntegrated.AutoSize = true;
            this.chkIntegrated.Location = new System.Drawing.Point(61, 200);
            this.chkIntegrated.Name = "chkIntegrated";
            this.chkIntegrated.Size = new System.Drawing.Size(149, 21);
            this.chkIntegrated.TabIndex = 49;
            this.chkIntegrated.Text = "Integrated Security";
            this.chkIntegrated.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(318, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 42);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(42, 32);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(138, 42);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FormDBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(485, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDBConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Banco de Dados";
            this.Load += new System.EventHandler(this.FormDBConfig_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPageServer.ResumeLayout(false);
            this.tabPageLocal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageServer;
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNomeBD;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkIntegrated;
        private System.Windows.Forms.TextBox txtAttachDB;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}