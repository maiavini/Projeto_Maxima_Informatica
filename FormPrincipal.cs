using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Maxima_Informatica
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            BaseDeDadosConfig.Config.TestarConexaoComBD();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void configuracaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseDeDadosConfig.Config.Configurar();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {            
            gridArtigos.AutoGenerateColumns = false;
            gridArtigos.DataSource = BaseDeDadosConfig.Config.ObterDados();
        }

        private void gridArtigos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridArtigos.CurrentRow != null)
            {
                DataGridViewRow row = gridArtigos.CurrentRow;
                BaseDeDadosConfig.Config.SalvarDados(row);
                gridArtigos.DataSource = BaseDeDadosConfig.Config.ObterDados();
            } 
        }

        private void gridArtigos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["STAMP"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Deseja excluir esse registro?", "Artigos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BaseDeDadosConfig.Config.RemoverRegistro(e.Row);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
