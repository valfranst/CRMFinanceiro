using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControle_V3
{
    class ClienteModel
    {

        private readonly RepresaContext _context;

        public ClienteModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, Cliente) Insert(Cliente cliente, Contato contato, Endereco endereco)
        {
            try
            {
                _context.Clientes.Add(cliente);
                _context.Contatos.Add(contato);
                _context.Enderecos.Add(endereco);
                Commit();
                Close();
                return (Resultado.Ok(), cliente);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public Resultado Update(Cliente cliente, Contato contato, Endereco endereco)
        {
            try
            {
                Cliente updateCliente = _context.Clientes.Where(at => at.IdCliente == cliente.IdCliente).FirstOrDefault();
                Contato updateContato = _context.Contatos.Where(at => at.IdCliente == cliente.IdCliente).FirstOrDefault();
                Endereco updateEndereco = _context.Enderecos.Where(at => at.IdCliente == cliente.IdCliente).FirstOrDefault();
                updateCliente = cliente;
                updateContato = contato;
                updateEndereco = endereco;
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

        public (Resultado, List<ViewCliente>) GetAll()
        {
            try
            {
                List<ViewCliente> clientes = _context.ViewClientes.OrderByDescending(at => at.NomeCliente).ToList();
                Close();
                return (Resultado.Ok(), clientes);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }


        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();


    } //
}
