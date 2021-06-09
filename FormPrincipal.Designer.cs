
namespace Projeto_Maxima_Informatica
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridArtigos = new System.Windows.Forms.DataGridView();
            this.STAMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.design = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridArtigos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // configuracaoToolStripMenuItem
            // 
            this.configuracaoToolStripMenuItem.Name = "configuracaoToolStripMenuItem";
            this.configuracaoToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.configuracaoToolStripMenuItem.Text = "Configuracao";
            this.configuracaoToolStripMenuItem.Click += new System.EventHandler(this.configuracaoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridArtigos
            // 
            this.gridArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArtigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STAMP,
            this.txtRef,
            this.design,
            this.preco_custo,
            this.preco_venda});
            this.gridArtigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridArtigos.Location = new System.Drawing.Point(0, 24);
            this.gridArtigos.Name = "gridArtigos";
            this.gridArtigos.RowHeadersWidth = 51;
            this.gridArtigos.RowTemplate.Height = 24;
            this.gridArtigos.Size = new System.Drawing.Size(932, 451);
            this.gridArtigos.TabIndex = 2;
            this.gridArtigos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArtigos_CellValueChanged);
            this.gridArtigos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridArtigos_UserDeletingRow);
            // 
            // STAMP
            // 
            this.STAMP.DataPropertyName = "STAMP";
            this.STAMP.HeaderText = "STAMP";
            this.STAMP.MinimumWidth = 6;
            this.STAMP.Name = "STAMP";
            this.STAMP.ReadOnly = true;
            this.STAMP.Width = 125;
            // 
            // txtRef
            // 
            this.txtRef.DataPropertyName = "ref";
            this.txtRef.HeaderText = "Ref";
            this.txtRef.MinimumWidth = 6;
            this.txtRef.Name = "txtRef";
            this.txtRef.ReadOnly = true;
            this.txtRef.Width = 125;
            // 
            // design
            // 
            this.design.DataPropertyName = "design";
            this.design.HeaderText = "Design";
            this.design.MinimumWidth = 6;
            this.design.Name = "design";
            this.design.ReadOnly = true;
            this.design.Width = 125;
            // 
            // preco_custo
            // 
            this.preco_custo.DataPropertyName = "preco_custo";
            this.preco_custo.HeaderText = "Preco Custo";
            this.preco_custo.MinimumWidth = 6;
            this.preco_custo.Name = "preco_custo";
            this.preco_custo.Width = 125;
            // 
            // preco_venda
            // 
            this.preco_venda.DataPropertyName = "preco_venda";
            this.preco_venda.HeaderText = "Preco Venda";
            this.preco_venda.MinimumWidth = 6;
            this.preco_venda.Name = "preco_venda";
            this.preco_venda.Width = 125;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 497);
            this.Controls.Add(this.gridArtigos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maxima Informatica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArtigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracaoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView gridArtigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqlConnectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn design;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_venda;
    }
}

