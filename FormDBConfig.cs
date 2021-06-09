using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Maxima_Informatica
{
    public partial class FormDBConfig : Form
    {
        public FormDBConfig()
        {
            InitializeComponent();
        }

        private void FormDBConfig_Load(object sender, EventArgs e)
        {
            txtInstancia.Text = BaseDeDadosConfig.Config.ServerName;
            txtNomeBD.Text = BaseDeDadosConfig.Config.DatabaseName;
            txtUtilizador.Text = BaseDeDadosConfig.Config.UserName;
            txtPassword.Text = BaseDeDadosConfig.Config.Password;

            txtDataSource.Text = BaseDeDadosConfig.Config.DataSource;
            txtAttachDB.Text = BaseDeDadosConfig.Config.AttachDbFilename;
            chkIntegrated.Checked = BaseDeDadosConfig.Config.IntegratedSecurity;
            txtTimeout.Text = BaseDeDadosConfig.Config.ConnectTimeOut;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            BaseDeDadosConfig.Config.ServerName = txtInstancia.Text;
            BaseDeDadosConfig.Config.DatabaseName = txtNomeBD.Text;
            BaseDeDadosConfig.Config.UserName = txtUtilizador.Text;
            BaseDeDadosConfig.Config.Password = txtPassword.Text;
            
            BaseDeDadosConfig.Config.DataSource = txtDataSource.Text;
            BaseDeDadosConfig.Config.AttachDbFilename = txtAttachDB.Text;
            BaseDeDadosConfig.Config.IntegratedSecurity = chkIntegrated.Checked;
            BaseDeDadosConfig.Config.ConnectTimeOut = txtTimeout.Text; 
            
            BaseDeDadosConfig.Config.SaveConfig();
        }   
    }
}
