using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace SistemaControle_V3
{
    class MyConfig
    {

        private static MyConfig _instance;
        private static readonly object _lock = new object();

        private Configuration configApp;
        private string _conexao;
        private string _local;
        private string _localImagem;
        private string _localImagemAplicativo;
        private string _localBanco;
        private string _meta;
        private string _cor;

        private MyConfig()
        {
            this.configApp = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            this._conexao = configApp.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
            this._local = configApp.AppSettings.Settings["local"].Value;
            this._localImagem = configApp.AppSettings.Settings["localImagem"].Value;
            this._localBanco = configApp.AppSettings.Settings["localBanco"].Value;
            this._localImagemAplicativo = configApp.AppSettings.Settings["localImagemAplicativo"].Value;
            this._meta = configApp.AppSettings.Settings["meta"].Value;
            this._cor = configApp.AppSettings.Settings["cor"].Value;
        }

        public static MyConfig _getInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MyConfig();
                    }
                }
            }
            return _instance;
        }
        public static MyConfig _getInstanceRefresh()
        {
            _instance = new MyConfig();
            return _instance;
        }

        #region GET and SET

        public string Conexao
        {
            get => _conexao;
            set
            {
                configApp.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + value + @"\Represa04.mdf;Integrated Security=True;Connect Timeout=30;Trusted_Connection=True";
                this._conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + value + @"\Represa04.mdf;Integrated Security=True;Connect Timeout=30;Trusted_Connection=True";
                configApp.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
                ConfigurationManager.RefreshSection("DefaultConnection");
                ConfigurationManager.RefreshSection("connectionStrings");
            }
        }

        public string Local
        {
            get => _local;
            set
            {
                _local = value;
                configApp.AppSettings.Settings["local"].Value = value;
                configApp.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public string Imagem
        {
            get => _localImagem;
            set
            {
                _localImagem = value;
                configApp.AppSettings.Settings["localImagem"].Value = value;
                configApp.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public string Banco
        {
            get => _localBanco;
            set
            {
                _localBanco = value;
                configApp.AppSettings.Settings["localBanco"].Value = value;
                configApp.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public string ImagemTemp
        {
            get => _localImagemAplicativo;
            set
            {
                _localImagemAplicativo = value;
                configApp.AppSettings.Settings["localImagemAplicativo"].Value = value;
                configApp.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public string Meta
        {
            get => _meta;
            set
            {
                _meta = value;
                configApp.AppSettings.Settings["meta"].Value = value;
                configApp.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public string Cor
        {
            get => _cor;
            set
            {
                _cor = value;
                configApp.AppSettings.Settings["cor"].Value = value;
                configApp.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        #endregion FIM GET and SET
                           
        public List<string> getTamanhoArquivo()
        {
            try
            {
                List<string> tamanhos = new List<string>();
                FileInfo db = new FileInfo(Banco + @"\Represa04.mdf");
                FileInfo log = new FileInfo(Banco + @"\Represa04_log.ldf");
                DirectoryInfo pasta = new DirectoryInfo(Local);
                string tamanhoBanco = "Tamanho arquivo Banco de Dados: " + ByteTo(db.Length);
                string tamanhoLog = "Tamanho arquivo LOG Banco de Dados: " + ByteTo(log.Length);
                string tamanhoPasta = "Tamanho da Pasta do SISTEMA: " + ByteTo(DirSize(pasta));
                string qtdImagens = "Quantidade de imagem salvas:  " + Directory.GetFiles(Imagem, "*", SearchOption.TopDirectoryOnly).Length;

                tamanhos.Add(tamanhoBanco);
                tamanhos.Add(tamanhoLog);
                tamanhos.Add(tamanhoPasta);
                tamanhos.Add(qtdImagens);

                return tamanhos;
            }
            catch {  return null; }

        }
                
        public static int UltimoDia(DateTime data)
        {
            // 1 3 5 7 8 10 12
            int ultimoDia = 30;
            switch (data.Month)
            {
                case 1:
                    ultimoDia = 31;
                    break;
                case 2:
                    ultimoDia = 28;
                    break;
                case 3:
                    ultimoDia = 31;
                    break;
                case 5:
                    ultimoDia = 31;
                    break;
                case 7:
                    ultimoDia = 31;
                    break;
                case 8:
                    ultimoDia = 31;
                    break;
                case 10:
                    ultimoDia = 31;
                    break;
                case 12:
                    ultimoDia = 31;
                    break;
                default:
                    break;
            }

            return ultimoDia;
        }

        public string ByteTo(long value)
        {
            string retorno = null;
            if (value / 1024 == 0)
            {
                retorno = value + " bytes";
            }
            else if (value / (1024 * 1024) == 0)
            {
                retorno = string.Format("{0:n1} KB", value / 1024f);
            }
            else if (value / (1024 * 1024 * 1024) == 0)
            {
                retorno = string.Format("{0:n1} MB", value / 1024f);
            }

            return retorno;
        }

        public long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }
        
    } //Fim Class
}
