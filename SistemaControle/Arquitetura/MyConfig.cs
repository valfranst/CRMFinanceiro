using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using Newtonsoft.Json;
using SistemaControle.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace SistemaControle.Arquitetura
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

        public Resultado checkDb()
        {
            try
            {

                if (File.Exists(@"C:\Aplicativo\Banco\Represa04.mdf")) Conexao = @"C:\Aplicativo\Banco";
                else if (File.Exists(@"D:\Aplicativo\Banco\Represa04.mdf")) { Conexao = @"D:\Aplicativo\Banco"; Local = @"D:\Aplicativo"; Banco = @"D:\Aplicativo\Banco"; Imagem = @"D:\Aplicativo\Imagens"; ImagemTemp = @"D:\Aplicativo\Imagens_Aplicativo"; }
                else if (File.Exists(@"E:\Aplicativo\Banco\Represa04.mdf")) { Conexao = @"E:\Aplicativo\Banco"; Local = @"E:\Aplicativo"; Banco = @"E:\Aplicativo\Banco"; Imagem = @"E:\Aplicativo\Imagens"; ImagemTemp = @"E:\Aplicativo\Imagens_Aplicativo"; }
                else if (File.Exists(@"F:\Aplicativo\Banco\Represa04.mdf")) { Conexao = @"F:\Aplicativo\Banco"; Local = @"F:\Aplicativo"; Banco = @"F:\Aplicativo\Banco"; Imagem = @"F:\Aplicativo\Imagens"; ImagemTemp = @"F:\Aplicativo\Imagens_Aplicativo"; }
                else if (File.Exists(@"G:\Aplicativo\Banco\Represa04.mdf")) { Conexao = @"G:\Aplicativo\Banco"; Local = @"G:\Aplicativo"; Banco = @"G:\Aplicativo\Banco"; Imagem = @"G:\Aplicativo\Imagens"; ImagemTemp = @"G:\Aplicativo\Imagens_Aplicativo"; }
                else if (File.Exists(@"H:\Aplicativo\Banco\Represa04.mdf")) { Conexao = @"H:\Aplicativo\Banco"; Local = @"H:\Aplicativo"; Banco = @"H:\Aplicativo\Banco"; Imagem = @"H:\Aplicativo\Imagens"; ImagemTemp = @"H:\Aplicativo\Imagens_Aplicativo"; }

                using (RepresaContext con = new RepresaContext())
                {
                    if (con.Database.CanConnect()) return Resultado.Ok();
                    else return IniciarEstrutura();
                }

            }
            catch (SqlException ex)
            {
                return Resultado.Erro("Erro ao conectar Banco de Dados! \n\n" + ex);
            }
            catch (Exception ex)
            {
                return Resultado.Erro("Erro ao conectar Banco de Dados! \n\n" + ex);
            }

        }

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

        public Resultado IniciarEstrutura()
        {
            try
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Selecione a pasta";
                if (folderBrowser.ShowDialog() == true)
                {
                    Local = Path.GetDirectoryName(folderBrowser.FileName);

                    if (Directory.Exists(Local))
                    {
                        Banco = Local + @"\Banco";
                        Imagem = Local + @"\Imagens";
                        ImagemTemp = Local + @"\Imagens_Aplicativo";
                    }
                    else return Resultado.Erro("A pasta RAIZ do Sistema não foi encontrada...");

                    if (!Directory.Exists(Banco)) return Resultado.Erro("A pasta do Banco de Dados não foi encontrada...");
                    if (!Directory.Exists(Imagem)) return Resultado.Erro("A pasta Imagens dos Clientes não foi encontrada...");
                    if (!Directory.Exists(ImagemTemp))
                    {
                        Directory.CreateDirectory(Local + @"\Imagens_Aplicativo");
                        ImagemTemp = Local + @"\Imagens_Aplicativo";
                    }
                    //System.Windows.MessageBox.Show("Conexao: " + Banco);
                    if (File.Exists(Banco + @"\Represa04.mdf")) Conexao = Banco;                     
                    else return Resultado.Erro("O ARQUIVO do Banco de Dados não foi encontrado: por favor verifique as pastas do SISTEMA!");

                }
                return Resultado.Ok();
            }
            catch (Exception ex)
            {
                return Resultado.Erro("Erro.Sisitema Interrompido!\n\n" + ex);
            }
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
             
        public void AtualizarEndereco()
        {

            System.Windows.MessageBox.Show("Inicio...................!");

            RepresaContext dc = new RepresaContext();
            List<Cliente> clientes = dc.Clientes.ToList();

            foreach(Cliente cli in clientes)
            {
                string enderecoResComposto = cli.EnderecoResidencial;
                string enderecoEmpComposto = cli.EnderecoEmpresarial;
                string ref1 = cli.Referencia1;
                string ref2 = cli.Referencia2;
                string ref3 = cli.Referencia3;

                string[] enderecosR = null;
                if (enderecoResComposto != null && enderecoResComposto.Contains("#")) enderecosR = enderecoResComposto.Split('#');

                string[] enderecosE = null;
                if (enderecoEmpComposto != null && enderecoEmpComposto.Contains("#")) enderecosE = enderecoEmpComposto.Split('#');

                string[] refs1 = null;
                if (ref1 != null) { refs1 = ref1.Split('#'); }

                string[] refs2 = null;
                if (ref2 != null) { refs2 = ref2.Split('#'); }

                string[] refs3 = null;
                if (ref3 != null) { refs3 = ref3.Split('#'); }


                try
                {
                    Endereco residencial = new Endereco();
                    if (enderecosR is null)
                    {
                        residencial.Cep = null;
                        residencial.EnderecoBase = null;
                        residencial.Bairro = null;
                        residencial.Cidade = null;
                        residencial.Estado = null;
                        residencial.PontoReferencia = null;
                    }
                    else
                    {
                        residencial.Cep = enderecosR[0];
                        residencial.EnderecoBase = enderecosR[1];
                        residencial.Bairro = enderecosR[2];
                        residencial.Cidade = enderecosR[3];
                        residencial.Estado = enderecosR[4];
                        if (enderecosR.Length > 5) residencial.PontoReferencia = enderecosR[5];
                        else residencial.PontoReferencia = null;
                    }




                    Endereco empresarial = new Endereco();
                    if(enderecosE is null)
                    {
                        empresarial.Cep = null;
                        empresarial.EnderecoBase = null;
                        empresarial.Bairro = null;
                        empresarial.Cidade = null;
                        empresarial.Estado = null;
                        empresarial.PontoReferencia = null;
                    }
                    else
                    {
                        empresarial.Cep = enderecosE[0];
                        empresarial.EnderecoBase = enderecosE[1];
                        empresarial.Bairro = enderecosE[2];
                        empresarial.Cidade = enderecosE[3];
                        empresarial.Estado = enderecosE[4];
                        if(enderecosE.Length > 5) empresarial.PontoReferencia = enderecosE[5];
                        else empresarial.PontoReferencia = null;
                    }
                    

                    Referencia referencia = new Referencia();
                    if (refs1 is null) { referencia.Referencia01 = null; referencia.Telefone01 = null; }
                    else { referencia.Referencia01 = refs1[0]; referencia.Telefone01 = refs1[1]; }

                    if (refs2 is null) { referencia.Referencia02 = null; referencia.Telefone02 = null; }
                    else { referencia.Referencia02 = refs2[0]; referencia.Telefone02 = refs2[1]; }

                    if (refs3 is null) { referencia.Referencia03 = null; referencia.Telefone03 = null; }
                    else { referencia.Referencia01 = refs3[0]; referencia.Telefone03 = refs3[1]; }



                    string jsonResidencial = JsonConvert.SerializeObject(residencial);
                    string jsonEmpresarial = JsonConvert.SerializeObject(empresarial);
                    string jsonReferencia = JsonConvert.SerializeObject(referencia);

                    Cliente editando = dc.Clientes.Where(c => c.IdCliente == cli.IdCliente).FirstOrDefault();
                    editando.EndResidencial = jsonResidencial;
                    editando.EndEmpresarial = jsonEmpresarial;
                    editando.Referencia = jsonReferencia;
                    dc.SaveChanges();

                }
                catch (Exception ex)
                {
                    //System.Windows.MessageBox.Show("ERRO!"+ ex);
                }
            }
            System.Windows.MessageBox.Show("Fim...................!");

        }
        
        


    } //Fim Class
}
