using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControle_V3
{
    class FormaPagamentoModel
    {

        private readonly RepresaContext _context;

        public FormaPagamentoModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, FormaPagamento) Insert(FormaPagamento formaPagamento)
        {
            try
            {
                _context.FormaPagamentos.Add(formaPagamento);
                Commit();
                Close();
                return (Resultado.Ok(), formaPagamento);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, FormaPagamento) Update(FormaPagamento formaPagamento)
        {
            try
            {
                FormaPagamento update = _context.FormaPagamentos.Where(at => at.IdFormaPagamento == formaPagamento.IdFormaPagamento).FirstOrDefault();
                update = formaPagamento;
                Commit();
                Close();
                return (Resultado.Ok(), update);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }

        }

        public Resultado Delete(FormaPagamento formaPagamento)
        {
            try
            {
                _context.FormaPagamentos.Remove(formaPagamento);
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }

        }

        public (Resultado, FormaPagamento) GetById(int id)
        {
            try
            {
                FormaPagamento formaPagamento = _context.FormaPagamentos.Where(at => at.IdFormaPagamento == id).FirstOrDefault();
                Close();
                return (Resultado.Ok(), formaPagamento);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, FormaPagamento) GetByNome(string nome)
        {
            try
            {
                FormaPagamento formaPagamento = _context.FormaPagamentos.Where(at => at.NomeFormaPagamento == nome).FirstOrDefault();
                Close();
                return (Resultado.Ok(), formaPagamento);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }


        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    }  //
}
