using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using SistemaControle.Model;

namespace SistemaControle.Arquitetura
{
    public class Query
    {
        private RepresaContext dc;
        private static Query _instance;
        private static readonly object _lock = new object();

        private Query()
        {
            dc = new RepresaContext();
        }

        public static Query _getInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Query();
                    }
                }
            }
            return _instance;
        }



        public IEnumerable<Cliente> GetClientes() => dc.Clientes.OrderBy(cli => cli.NomeCliente).ToList();
        public Cliente GetClienteById(int idCliente) => dc.Clientes.Where(cli => cli.IdCliente == idCliente).FirstOrDefault();
        public IEnumerable<Cliente> GetClienteByPesquisa(string pesquisa) => dc.Clientes.Where(cli => cli.Pesquisa.Contains(pesquisa)).OrderBy(cli => cli.NomeCliente);
        public Resultado InsertCliente(Cliente cliente)
        {
            try
            {
                dc.Clientes.Add(cliente);
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao salvar novo CLIENTE!\n\n" + ex); }
        }
        public Resultado UpdateCliente(Cliente cliente)
        {
            try
            {
                Cliente novoCliente = dc.Clientes.Where(cli => cli.IdCliente == cliente.IdCliente).FirstOrDefault();
                novoCliente = cliente;
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao atualizar CLIENTE!\n\n" + ex); }
        }
        public Resultado DeleteCliente(Cliente cliente)
        {
            try
            {
                dc.Clientes.Remove(cliente);
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao Excluir o CLIENTE!\n\n" + ex); }
        }
        public IEnumerable<Cliente> GetCadClientes() => dc.Clientes.OrderByDescending(p => p.DataCadastro).Take(5);




        public IEnumerable<Emprestimo> GetEmprestimos(int idCliente) => dc.Emprestimos.Where(emp => (emp.IdCliente == idCliente));
        public Emprestimo GetEmprestimoById(int idEmprestimo) => dc.Emprestimos.Where(em => em.IdCliente == idEmprestimo).FirstOrDefault();
        public Resultado InsertEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dc.Emprestimos.Add(emprestimo);
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao salvar novo Emprestimo!\n\n" + ex); }
        }
        public Resultado UpdateEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                Emprestimo novoEmprestimo = dc.Emprestimos.Where(em => em.IdEmprestimo == emprestimo.IdEmprestimo).FirstOrDefault();
                novoEmprestimo = emprestimo;
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao atualizar o Emprestimo!\n\n" + ex); }
        }
        public Resultado DeleteEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dc.Emprestimos.Remove(emprestimo);
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao excluir o Emprestimo!\n\n" + ex); }
        }
        public IEnumerable<Emprestimo> GetCadEmprestimo() => dc.Emprestimos.OrderByDescending(p => p.DataCadastro).Take(5);




        public IEnumerable<Parcela> GetParcelas(int idEmprestimo) => dc.Parcelas.Where(par => (par.IdEmprestimo == idEmprestimo));
        public Parcela GetParcelaById(int idParcela) => dc.Parcelas.Where(par => par.IdParcela == idParcela).FirstOrDefault();
        public Resultado InsertParcela(Parcela parcela)
        {
            try
            {
                dc.Parcelas.Add(parcela);
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao salvar nova Parcela!\n\n" + ex); }
        }
        public Resultado InsertParcelas(IEnumerable<Parcela> parcelas)
        {
            try
            {
                dc.Parcelas.AddRange(parcelas);
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao salvar novas Parcelas!\n\n" + ex); }
        }
        public Resultado UpdateParcela(Parcela parcela)
        {
            try
            {
                Parcela novaParcela = dc.Parcelas.Where(par => par.IdParcela == parcela.IdParcela).FirstOrDefault();
                novaParcela = parcela;
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao atualizar a Parcela!\n\n" + ex); }
        }
        public Resultado DeleteParcela(Parcela parcela)
        {
            try
            {
                dc.Parcelas.Remove(parcela);
                dc.SaveChanges();
                return Resultado.Ok();
            }
            catch (SqlException ex) { return Resultado.Erro("Error ao excluir a Parcela!\n\n" + ex); }
        }




        public IEnumerable<ViewRefinanciar> GetRefinanciar(DateTime inicio, DateTime fim) => dc.ViewRefinanciars.Where(vref => (vref.UltimaParcela >= inicio && vref.UltimaParcela <= fim));
        public IEnumerable<ViewRecebimento> GetRecebimento(DateTime inicio, DateTime fim) => dc.ViewRecebimentos.Where(vrec => (vrec.Vencimento >= inicio && vrec.Vencimento <= fim));
        public IEnumerable<ViewAplicacaoCliente> GetProducao(DateTime inicio, DateTime fim) => dc.ViewAplicacaoClientes.Where(prod => (prod.DataCadastro >= inicio && prod.DataCadastro <= fim));
        public IEnumerable<ViewParcelaEmprestimo> GetParcelaEmprestimos(int idEmprestimo) => dc.ViewParcelaEmprestimos.Where(paremp => (paremp.IdEmprestimo == idEmprestimo));



        public IEnumerable<string> GetUltimosCodigos(DateTime inicio, DateTime fim) => (from emp in dc.Emprestimos where (emp.DataCadastro >= inicio && emp.DataCadastro <= fim) orderby emp.IdEmprestimo descending select emp.CodEmprestimo).Take(4);
        public String GetUltimoCodigo(DateTime inicio, DateTime fim) => dc.Emprestimos.Where(emp => emp.DataCadastro >= inicio && emp.DataCadastro <= fim).OrderByDescending(emp => emp.IdEmprestimo).Select(emp => emp.CodEmprestimo).FirstOrDefault();
        public String GetCodigoByCodigo(string codEmprestimo) => dc.Emprestimos.Where(emp => emp.CodEmprestimo == codEmprestimo).Select(emp => emp.CodEmprestimo).FirstOrDefault();


        public IEnumerable<string> GetFormaPagamentos() => dc.FormaPagamentos.Select(fp => fp.NomeFormaPagamento);
        public IEnumerable<string> GetFuncionarios() => dc.Atendentes.Select(at => at.NomeAtendente);
        public int GetClientesCount() => dc.Clientes.Select(cli => cli.IdCliente).Count();


        public Resultado ExecuteSP_Parcela(int idEmprestimo)
        {
            try
            {
                var result = dc.Database.ExecuteSqlRaw("EXECUTE dbo.SP_EmprestimoP_Parcela;", idEmprestimo);
                return Resultado.Ok();
            }
            catch (Exception ex)
            {
                return Resultado.Erro("Store Procedure não executada!\n\n" + ex);
            }
        }



    } //Fim Class
}
