using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Maxima_Informatica
{
    public class BaseDeDadosConfig
    {
        private static BaseDeDadosConfig config; //Propriedade estática do padrão SINGLETON
        private readonly FormDBConfig formDBConfig;

        public string DataSource;
        public string AttachDbFilename;
        public bool IntegratedSecurity;
        public string ConnectTimeOut;

        public string ServerName;
        public string DatabaseName;
        public string UserName;
        public string Password;
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        private DataTable table;

        public static BaseDeDadosConfig Config // Instaciamento da classe uma única vez
        {
            get //Get do SINGLETON 
            {
                if (config == null)
                {
                    config = new BaseDeDadosConfig();
                }
                return config;
            }
        }

        private BaseDeDadosConfig() //Instância do Formulário de Configuração do Banco de Dados 
        {
            formDBConfig = new FormDBConfig();
        }

        public void TestarConexaoComBD()
        {
            try
            {
                LoadConfig();
                var connectionString = GetConnectionString();
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();


            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao carregar configuracao do Banco de Dados! \n\r" + e.Message);

                if (formDBConfig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TestarConexaoComBD();
                }
            }
        }

        internal void Configurar()
        {
            if (formDBConfig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TestarConexaoComBD();
            }
        }

        private string GetConnectionString()
        {
            string baseConnection = string.Empty;
            if (string.IsNullOrEmpty(ServerName))
            {
                baseConnection = $"Data Source={DataSource};AttachDbFilename={AttachDbFilename};";
            }
            else
            {
                baseConnection = $"Server={ServerName};Database={DatabaseName};";
            }

            if (IntegratedSecurity)
            {
                return $"{baseConnection};Integrated Security={IntegratedSecurity.ToString()};Connect Timeout={ConnectTimeOut};";
            }
            else
            {
                return $"{baseConnection};User Id={UserName};Password={Password};";
            }
        }

        private void LoadConfig() //Carregamento da Aplicação rebendo informações do XML
        {
            ServerName = ConfigurationManager.AppSettings.Get("ServerName");
            DatabaseName = ConfigurationManager.AppSettings.Get("DatabaseName");
            UserName = ConfigurationManager.AppSettings.Get("UserName");
            Password = ConfigurationManager.AppSettings.Get("Password");

            DataSource = ConfigurationManager.AppSettings.Get("DataSource");
            AttachDbFilename = ConfigurationManager.AppSettings.Get("AttachDbFilename");
            IntegratedSecurity = ConfigurationManager.AppSettings.Get("IntegratedSecurity") == null
                                 ? false
                                 : bool.Parse(ConfigurationManager.AppSettings.Get("IntegratedSecurity"));
            ConnectTimeOut = ConfigurationManager.AppSettings.Get("ConnectTimeout");
        }

        public void SaveConfig() //Retornando as informações ao XML
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            settings["ServerName"].Value = ServerName;
            settings["DatabaseName"].Value = DatabaseName;
            settings["UserName"].Value = UserName;
            settings["Password"].Value = Password;

            settings["DataSource"].Value = DataSource;
            settings["AttachDbFilename"].Value = AttachDbFilename;
            settings["IntegratedSecurity"].Value = IntegratedSecurity.ToString();
            settings["ConnectTimeOut"].Value = ConnectTimeOut;

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        internal DataTable ObterDados()
        {
            SqlCommand command = new SqlCommand("select * from artigos", sqlConnection);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            table = new DataTable();            
            adapter.Fill(table);

            return table;
        }

        internal void SalvarDados(DataGridViewRow row)
        {
            try
            {
                var stamp = row.Cells["STAMP"].Value;
                var custo = row.Cells["preco_custo"].Value == DBNull.Value ? 0 : row.Cells["preco_custo"].Value;
                var venda = row.Cells["preco_venda"].Value == DBNull.Value ? 0 : row.Cells["preco_venda"].Value;

                string cmd = string.Empty;

                if (stamp == DBNull.Value) // Inserindo novo registro
                {
                    cmd = $"insert into artigos (stamp, ref, design, preco_custo, preco_venda ) values ('{Guid.NewGuid().ToString().Substring(0,24)}','ref','design',{custo},{venda})";
                }
                else
                {
                    cmd = $"update artigos set preco_custo = {custo}, preco_venda = {venda} where STAMP = '{stamp}'";
                }

                SqlCommand command = new SqlCommand(cmd, sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao atualizar banco de dados \n\r {e.Message}");
            }            
        }

        internal void RemoverRegistro(DataGridViewRow row)
        {
            try
            {
                SqlCommand command = new SqlCommand($"delete from artigos where STAMP = '{row.Cells["STAMP"].Value}'", sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao excluir registro \n\r {e.Message}");
            }
        }
    }
}
