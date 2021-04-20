using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaControle_V3
{
    class ClienteModel
    {

        private readonly RepresaContext _context;

        public ClienteModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, Cliente) Insert(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                Commit();
                Close();
                return (Resultado.Ok(), cliente);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public Resultado Update(Cliente cliente)
        {
            try
            {
                Cliente updateCliente = _context.Clientes.Where(at => at.IdCliente == cliente.IdCliente).FirstOrDefault();
                updateCliente = cliente;
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }

        }

        public Resultado Delete(Cliente cliente)
        {
            try
            {
                _context.Clientes.Remove(cliente);
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }

        }

        public (Resultado, Cliente) GetById(int id)
        {
            try
            {
                Cliente cliente = _context.Clientes.Where(at => at.IdCliente == id).FirstOrDefault();
                Close();
                return (Resultado.Ok(), cliente);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, Cliente) GetByNome(string nome)
        {
            try
            {
                Cliente cliente = _context.Clientes.Where(at => at.NomeCliente == nome).FirstOrDefault();
                Close();
                return (Resultado.Ok(), cliente);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, List<ViewListCliente>) GetAll()
        {
            try
            {
                List<ViewListCliente> clientes = _context.ViewListClientes.OrderByDescending(at => at.NomeCliente).ToList();
                Close();
                return (Resultado.Ok(), clientes);
            }
            catch (Exception ex) { return (Resultado.Erro("Erro ao carregar Lista de Clientes! \n\n" + ex), null); }
            finally { Close(); }
        }

        public (Resultado, List<ViewListCliente>) GetAll(int opcao)
        {
            try
            {
                List<ViewListCliente> inativos = _context.ViewListClientes.OrderByDescending(at => at.NomeCliente).ToList();
                Close();

                List<ViewListCliente> clientes = new();
                DateTime inicio, fim;

                if (opcao == 1)
                {
                    clientes.Clear();
                    inicio = DateTime.Now.AddMonths(-3);
                    fim = DateTime.Now.AddMonths(-6);
                    foreach (ViewListCliente cliente in inativos) 
                    {
                        if (cliente.UltimaParcela < inicio && cliente.UltimaParcela > fim) clientes.Add(cliente);
                    }
                    return (Resultado.Ok(), clientes);
                }
                else if (opcao == 2)
                {
                    clientes.Clear();
                    inicio = DateTime.Now.AddMonths(-6);
                    fim = DateTime.Now.AddMonths(-9);
                    foreach (ViewListCliente cliente in inativos)
                    {
                        if (cliente.UltimaParcela < inicio && cliente.UltimaParcela > fim) clientes.Add(cliente);
                    }
                    return (Resultado.Ok(), clientes);
                }
                else if (opcao == 3)
                {
                    clientes.Clear();
                    inicio = DateTime.Now.AddMonths(-9);
                    fim = DateTime.Now.AddMonths(-12);
                    foreach (ViewListCliente cliente in inativos)
                    {
                        if (cliente.UltimaParcela < inicio && cliente.UltimaParcela > fim) clientes.Add(cliente);
                    }
                    return (Resultado.Ok(), clientes);
                }
                else if (opcao == 4)
                {
                    clientes.Clear();
                    inicio = DateTime.Now.AddMonths(-12);
                    foreach (ViewListCliente cliente in inativos)
                    {
                        if (cliente.UltimaParcela < inicio || cliente.UltimaParcela is null) clientes.Add(cliente);
                    }
                    return (Resultado.Ok(), clientes);
                }
                else return (Resultado.Erro("Erro ao carregar clientes inativos!"), null);
            }
            catch (Exception ex) { return (Resultado.Erro("Erro ao carregar Lista de Clientes! \n\n" + ex), null); }
            finally { Close(); }
        }

        //*****************************************************************

        public (Resultado, int?) GetCount()
        {
            try
            {
                int? countClientes = _context.Clientes.Count();
                Close();
                return (Resultado.Ok(), countClientes);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, List<Cliente>) GetAtualizados()
        {
            try
            {
                List<Cliente> clientes = _context.Clientes.OrderByDescending(p => p.DataCadastro).Take(5).ToList();
                return (Resultado.Ok(), clientes);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }





        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();


    } //
}
