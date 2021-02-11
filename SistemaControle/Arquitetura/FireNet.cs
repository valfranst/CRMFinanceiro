using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaControle.Model;

namespace SistemaControle.Arquitetura
{
    class FireNet
    {
        private const string BasePath = "https://ponterepresa-default-rtdb.firebaseio.com";
        private const string FirebaseSecret = "iiEiwQnjyhy6cD54Z6yyBuBo5orqG2yS7nXsBZ0j";
        private FirebaseClient client;
        MyConfig myConfig;
        MainWindow mw;
        string raiz = "Atualizacoes";

        public FireNet(MainWindow mainWindow)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = FirebaseSecret,
                BasePath = BasePath
            };
            this.client = new FirebaseClient(config);
            myConfig = MyConfig._getInstance();
            this.mw = mainWindow;
            raiz = mw.txtPemDriver.Content.ToString();
        }


        public Resultado InserirPonte(List<Espelho> espelhos)
        {
            try
            {   
                Dictionary<string, Espelho> subindo = new Dictionary<string, Espelho>();
                string id;
                DateTime dataId = DateTime.Now;
                foreach (Espelho espelho in espelhos)
                {
                    Thread.Sleep(2000);
                    id = DateTime.Now.ToString("ddMMyyyyHHmmss");
                    subindo.Add(id, espelho);
                }

                SetResponse response = client.Set(raiz, subindo);
                return Resultado.Ok();


            }
            catch (Exception ex) { return Resultado.Erro(ex.ToString()); }
        }


        public Resultado BaixarPonteAsync()
        {
            RepresaContext dc = new RepresaContext();

            try
            {
                string afluente = null;
                if (raiz == "Escritorio") afluente = "Casa";
                else if (raiz == "Casa") afluente = "Escritorio";

                FirebaseResponse response = client.Get(afluente);  // set
                Object espelho = response.ResultAs<Object>(); //A resposta conterá os dados sendo recuperados

                if (espelho is not null)
                {
                    Dictionary<string, Espelho> espelhos = JsonConvert.DeserializeObject<Dictionary<string, Espelho>>(espelho.ToString());
                    // DateTime ParseData = DateTime.ParseExact(data, "ddMMyyyyHHmm", CultureInfo.InvariantCulture);
                    List<Espelho> espelhosBase = new List<Espelho>();

                    foreach (KeyValuePair<string, Espelho> entry in espelhos)
                    {

                        if (entry.Value.Tipo.Name == "Atendente")
                        {
                            Atendente atendente = JsonConvert.DeserializeObject<Atendente>(entry.Value.Dado);
                            if (entry.Value.Acao == "Inserir")
                            {
                                dc.Atendentes.Add(atendente);
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Atualizar")
                            {
                                Atendente atualizando = dc.Atendentes.Where(busca => busca.IdAtendente == atendente.IdAtendente).FirstOrDefault();
                                atualizando.NomeAtendente = atendente.NomeAtendente;
                                atualizando.Descricao = atendente.Descricao;
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Excluir")
                            {
                                int id = 0;
                                id = (from busca in dc.Atendentes where busca.IdAtendente == atendente.IdAtendente select busca.IdAtendente).FirstOrDefault();
                                if (id > 0)
                                {
                                    dc.Atendentes.Remove(atendente);
                                    dc.SaveChanges();
                                }
                            }
                        }//*******************************************************

                        if (entry.Value.Tipo.Name == "Cliente")
                        {
                            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(entry.Value.Dado);
                            if (entry.Value.Acao == "Inserir")
                            {
                                dc.Clientes.Add(cliente);
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Atualizar")
                            {
                                Cliente atualizando = dc.Clientes.Where(busca => busca.IdCliente == cliente.IdCliente).FirstOrDefault();

                                if (atualizando is not null)
                                {

                                    atualizando.NomeCliente = cliente.NomeCliente;
                                    atualizando.NomeClienteNormalizado = cliente.NomeClienteNormalizado;
                                    atualizando.DataNascimento = cliente.DataNascimento;
                                    atualizando.Cpf = cliente.Cpf;
                                    atualizando.Rg = cliente.Rg;
                                    atualizando.TelResidencial = cliente.TelResidencial;
                                    atualizando.TelCelularzap = cliente.TelCelularzap;
                                    atualizando.TelCelular2 = cliente.TelCelular2;
                                    atualizando.Email = cliente.Email;
                                    atualizando.Facebook = cliente.Facebook;
                                    atualizando.Instagran = cliente.Instagran;

                                    atualizando.EndResidencial = cliente.EndResidencial;

                                    atualizando.Empresa = cliente.Empresa;
                                    atualizando.Cargo = cliente.Cargo;
                                    atualizando.SalarioLiquido = cliente.SalarioLiquido;
                                    atualizando.DataEmpresa = cliente.DataEmpresa;
                                    atualizando.TelComercial1 = cliente.TelComercial1;
                                    atualizando.TelComercial2 = cliente.TelComercial2;
                                    atualizando.TelComercial3 = cliente.TelComercial3;

                                    atualizando.EndEmpresarial = cliente.EndEmpresarial;

                                    atualizando.Referencia = cliente.Referencia;

                                    atualizando.Indicacao = cliente.Indicacao;
                                    atualizando.Observacao = cliente.Observacao;

                                    dc.SaveChanges();
                                    mw.clientePesquisa.AtualizarDados();
                                }
                            }
                            if (entry.Value.Acao == "Excluir")
                            {
                                int id = 0;
                                id = (from busca in dc.Clientes where busca.IdCliente == cliente.IdCliente select busca.IdCliente).FirstOrDefault();
                                if (id > 0)
                                {
                                    dc.Clientes.Remove(cliente);
                                    dc.SaveChanges();
                                }
                            }
                        }//*******************************************************

                        if (entry.Value.Tipo.Name == "DespesaMensal")
                        {
                            DespesaMensal despM = JsonConvert.DeserializeObject<DespesaMensal>(entry.Value.Dado);
                            if (entry.Value.Acao == "Inserir")   //DespesaMensal nao tem id Automatico
                            {
                                dc.DespesaMensals.Add(despM);
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Atualizar")
                            {
                                DespesaMensal atualizando = dc.DespesaMensals.Where(busca => busca.IdDespesaMensal == despM.IdDespesaMensal).FirstOrDefault();
                                atualizando.DataCadastro = despM.DataCadastro;
                                atualizando.Valor = despM.Valor;
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Excluir")
                            {
                                string id = "0";
                                id = (from busca in dc.DespesaMensals where busca.IdDespesaMensal == despM.IdDespesaMensal select busca.IdDespesaMensal).FirstOrDefault();
                                if (id.Length > 4)
                                {
                                    dc.DespesaMensals.Remove(despM);
                                    dc.SaveChanges();
                                }
                            }
                        }//*******************************************************

                        if (entry.Value.Tipo.Name == "Emprestimo")
                        {
                            Emprestimo emprestimo = JsonConvert.DeserializeObject<Emprestimo>(entry.Value.Dado);
                            if (entry.Value.Acao == "Inserir")
                            {
                                dc.Emprestimos.Add(emprestimo);
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Atualizar")
                            {
                                Emprestimo atualizando = dc.Emprestimos.Where(busca => busca.IdEmprestimo == emprestimo.IdEmprestimo).FirstOrDefault();
                                
                                atualizando.IdCliente = emprestimo.IdCliente;
                                atualizando.CodEmprestimo = emprestimo.CodEmprestimo;
                                atualizando.DataCadastro = emprestimo.DataCadastro;
                                atualizando.Valor = emprestimo.Valor;
                                atualizando.Taxa = emprestimo.Taxa;
                                atualizando.Fator = emprestimo.Fator;
                                atualizando.ValorTotal = emprestimo.ValorTotal;
                                atualizando.QtdParcela = emprestimo.QtdParcela;
                                atualizando.ValorParcela = emprestimo.ValorParcela;
                                atualizando.ValorComissao = emprestimo.ValorComissao;
                                atualizando.NomeAtendente = emprestimo.NomeAtendente;
                                atualizando.PrimeiraParcela = emprestimo.PrimeiraParcela;
                                atualizando.UltimaParcela = emprestimo.UltimaParcela;
                                atualizando.Observacao = emprestimo.Observacao;
                                atualizando.PercentComissao = emprestimo.PercentComissao;
                                atualizando.FormaPagamento = emprestimo.FormaPagamento;
                                atualizando.TotalRefinanciado = emprestimo.TotalRefinanciado;
                                atualizando.ReferenciaEmprestimo = emprestimo.ReferenciaEmprestimo;

                                atualizando.DataCadastroAlteracao = emprestimo.DataCadastroAlteracao;

                                atualizando.Refinanciado = emprestimo.Refinanciado;
                                atualizando.Complemento = emprestimo.Complemento;
                                atualizando.StatusEmprestimo = emprestimo.StatusEmprestimo;

                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Excluir")
                            {
                                int id = 0;
                                id = (from busca in dc.Emprestimos where busca.IdEmprestimo == emprestimo.IdEmprestimo select busca.IdCliente).FirstOrDefault();
                                if (id > 0)
                                {
                                    dc.Emprestimos.Remove(emprestimo);
                                    dc.SaveChanges();
                                }
                            }
                        }//*******************************************************

                        if (entry.Value.Tipo.Name == "Feriado")
                        {
                            Feriado feriado = JsonConvert.DeserializeObject<Feriado>(entry.Value.Dado);
                            if (entry.Value.Acao == "Inserir")
                            {
                                dc.Feriados.Add(feriado);
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Atualizar")
                            {
                                Feriado atualizando = dc.Feriados.Where(busca => busca.IdFeriado == feriado.IdFeriado).FirstOrDefault();
                                atualizando.NomeFeriado = feriado.NomeFeriado;
                                atualizando.DataFeriado = feriado.DataFeriado;
                                atualizando.Anual = feriado.Anual;
                                atualizando.Descricao = feriado.Descricao;
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Excluir")
                            {
                                int id = 0;
                                id = (from busca in dc.Feriados where busca.IdFeriado == feriado.IdFeriado select busca.IdFeriado).FirstOrDefault();
                                if (id > 0)
                                {
                                    dc.Feriados.Remove(feriado);
                                    dc.SaveChanges();
                                }
                            }
                        }//*******************************************************

                        if (entry.Value.Tipo.Name == "FormaPagamento")
                        {
                            FormaPagamento formaPagamento = JsonConvert.DeserializeObject<FormaPagamento>(entry.Value.Dado);
                            if (entry.Value.Acao == "Inserir")
                            {
                                dc.FormaPagamentos.Add(formaPagamento);
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Atualizar")
                            {
                                FormaPagamento atualizando = dc.FormaPagamentos.Where(busca => busca.IdFormaPagamento == formaPagamento.IdFormaPagamento).FirstOrDefault();
                                atualizando.NomeFormaPagamento = formaPagamento.NomeFormaPagamento;
                                atualizando.Descricao = formaPagamento.Descricao;
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Excluir")
                            {
                                int id = 0;
                                id = (from busca in dc.FormaPagamentos where busca.IdFormaPagamento == formaPagamento.IdFormaPagamento select busca.IdFormaPagamento).FirstOrDefault();
                                if (id > 0)
                                {
                                    dc.FormaPagamentos.Remove(formaPagamento);
                                    dc.SaveChanges();
                                }
                            }
                        }//*******************************************************

                        if (entry.Value.Tipo.Name == "Parcela")
                        {
                            Parcela parcela = JsonConvert.DeserializeObject<Parcela>(entry.Value.Dado);
                            if (entry.Value.Acao == "Inserir")
                            {
                                int idEmpres = dc.Emprestimos.Max(emp => emp.IdEmprestimo);
                                parcela.IdEmprestimo = idEmpres;
                                dc.Parcelas.Add(parcela);
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Atualizar")
                            {
                                Parcela atualizando = dc.Parcelas.Where(busca => busca.IdParcela == parcela.IdParcela).FirstOrDefault();
                                atualizando.IdEmprestimo = parcela.IdEmprestimo;
                                atualizando.Paga = parcela.Paga;
                                atualizando.ValorParcela = parcela.ValorParcela;
                                atualizando.Vencimento = parcela.Vencimento;
                                atualizando.FormaPagamento = parcela.FormaPagamento;
                                atualizando.Observacao = parcela.Observacao;
                                dc.SaveChanges();
                            }
                            if (entry.Value.Acao == "Excluir")
                            {
                                int id = 0;
                                id = (from busca in dc.Parcelas where busca.IdParcela == parcela.IdParcela select busca.IdParcela).FirstOrDefault();
                                if (id > 0)
                                {
                                    dc.Parcelas.Remove(parcela);
                                    dc.SaveChanges();
                                }
                            }
                        }//*******************************************************

                    }

                    dc.Dispose();
                    return Resultado.Ok();
                }
                else return Resultado.Erro("Não existe dados para serem atualizados no PenDriver "+raiz+".\nCaso necessario mude o nome do PenDriver no qual está trabalhando");

            }
            catch (Exception ex) { return Resultado.Erro(ex.ToString()); }
            finally { dc.Dispose(); }               
        }

        public void ExcluirPonte()
        {
            
            if (MainWindow.IsConnected() == 0)
            {
                try
                {
                    FirebaseResponse response = client.Delete(raiz); //Deletes todos collectio
                }
                catch (Exception) { /*return Resultado.Erro(ex);*/ }
            }
            else
            {
                MessageBox.Show("Não foi possível se conectar. Por favor verifique/reestabeleça a conexão com a INTERNET.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }             
        }
        public void ExcluirPonte(string id)
        {
            if (MainWindow.IsConnected() == 0)
            {
                try
                {
                    FirebaseResponse response = client.Delete(raiz +"/id"); //Deletes todos collectio
                }
                catch (Exception) { /*return Resultado.Erro(ex);*/ }
            }
            else
            {
                MessageBox.Show("Não foi possível se conectar. Por favor verifique/reestabeleça a conexão com a INTERNET.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        public void ExcluirPonte(List<string> ids)
        {
            if (MainWindow.IsConnected() == 0)
            {
                try
                {
                    foreach(string id in ids)
                    {
                        FirebaseResponse response = client.Delete(raiz + "/id"); //Deletes todos collectio
                    }                     
                }
                catch (Exception) { /*return Resultado.Erro(ex);*/ }
            }
            else
            {
                MessageBox.Show("Não foi possível se conectar. Por favor verifique/reestabeleça a conexão com a INTERNET.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        public List<Espelho> getFileJson()
        {
            string json = File.ReadAllText(myConfig.Local + @"\exportar.json");
            List<Espelho> espelhos = JsonConvert.DeserializeObject<List<Espelho>>(json);
            if (espelhos is null) return null;
            return espelhos;
        }
        public Resultado setFileJson(Espelho espelho)
        {
            try
            {  
                List<Espelho> espelhos;

                if (File.Exists(myConfig.Local + @"\exportar.json"))
                {
                    espelhos = getFileJson();
                    if (espelhos is null) espelhos = new List<Espelho>();
                        espelhos.Add(espelho);
                        File.WriteAllText(myConfig.Local + @"\exportar.json", JsonConvert.SerializeObject(espelhos));
                        mw.btUpload.Background = Brushes.Red;
                        mw.btUpload.IsEnabled = true;
                     
                }
                else
                {
                    espelhos = new List<Espelho>();
                    espelhos.Add(espelho);
                    FileStream str = File.Create(myConfig.Local + @"\exportar.json");
                    str.Close();
                    File.WriteAllText(myConfig.Local + @"\exportar.json", JsonConvert.SerializeObject(espelhos));                     
                    mw.btUpload.Background = Brushes.Red;
                    mw.btUpload.IsEnabled = true;
                }
            }
            catch(Exception ex) { return Resultado.Erro(ex.ToString()); }
            return Resultado.Ok();
        }

        public Resultado setFileJson(List<Espelho> espelhos2)
        {
            try
            {
                List<Espelho> espelhos;

                if (File.Exists(myConfig.Local + @"\exportar.json"))
                {
                    espelhos = getFileJson();
                    if (espelhos is null)
                    {
                        File.WriteAllText(myConfig.Local + @"\exportar.json", JsonConvert.SerializeObject(espelhos2));
                    }
                    else
                    {
                        foreach(Espelho espelho in espelhos2)
                        {
                            espelhos.Add(espelho);
                        }
                        File.WriteAllText(myConfig.Local + @"\exportar.json", JsonConvert.SerializeObject(espelhos));
                        mw.btUpload.Background = Brushes.Red;
                    }
                }
                else
                {                       
                    FileStream str = File.Create(myConfig.Local + @"\exportar.json");
                    str.Close();
                    File.WriteAllText(myConfig.Local + @"\exportar.json", JsonConvert.SerializeObject(espelhos2));
                    mw.btUpload.Background = Brushes.Red;
                }
            }
            catch (Exception ex) { return Resultado.Erro(ex.ToString()); }
            return Resultado.Ok();
        }



        //IFirebaseConfig config = new FirebaseConfig
        //{
        //    AuthSecret = FirebaseSecret,
        //    BasePath = BasePath
        //};
        //IFirebaseClient client = new FirebaseClient(config);

        //FireSharp.Response.FirebaseResponse response = await client.GetAsync("Atualizacoes");
        //var obj = response.ResultAs<Object>();
        //Console.WriteLine(obj.ToString());

        //EventStreamResponse responseA = await client.OnAsync("todos", (sender, args, context) => {
        //    System.Console.WriteLine(args.Data);
        //});


        //Todo todo = new Todo { name = "Execute SET 01", priority = 1 };
        //SetResponse response1 = await client.SetAsync("todos/set", todo);
        //Todo result = response1.ResultAs<Todo>(); //A resposta conterá os dados gravados
        //Console.WriteLine("\n" + result.name + " \n" + result.priority); 

        //FireSharp.Response.FirebaseResponse response3 = await client.GetAsync("Atualizacoes/get");  // set
        //todo = response3.ResultAs<Todo>(); //A resposta conterá os dados sendo recuperados
        //Console.WriteLine("FIireSharp GET\n" + result.name + " \n" + result.priority);

        //todo = new Todo { name = "Execute UPDATE 03", priority = 3 };
        //FireSharp.Response.FirebaseResponse response4 = await client.UpdateAsync("todos/set", todo);
        //todo = response4.ResultAs<Todo>(); //A resposta conterá os dados gravados
        //Console.WriteLine("\n" + result.name + " \n" + result.priority);

        //FireSharp.Response.FirebaseResponse response5 = await client.DeleteAsync("todos"); //Deletes todos collection
        //Console.WriteLine("FIireSharp DELETE\n" + response5.StatusCode);

        //FireSharp.Response.FirebaseResponse response6 = await client.GetAsync("Atualizacoes/02");  // set
        //var OBJ = response6.ResultAs<Object>(); //A resposta conterá os dados sendo recuperados
        //Console.WriteLine("FIireSharp GET Atualizacoes/02\n" + OBJ.ToString());



    } //**************************************
}
