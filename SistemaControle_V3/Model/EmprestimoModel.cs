using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaControle_V3
{
    class EmprestimoModel
    {

        private readonly RepresaContext _context;

        public EmprestimoModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, Emprestimo) Insert(Emprestimo emprestimo, List<Parcela> parcelas)
        {
            try
            {
                _context.Emprestimos.Add(emprestimo);
                _context.Parcelas.AddRange(parcelas);
                Commit();
                Close();
                return (Resultado.Ok(), emprestimo);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, Emprestimo) Update(Emprestimo emprestimo)
        {
            try
            {
                Emprestimo update = _context.Emprestimos.Where(at => at.IdEmprestimo == emprestimo.IdEmprestimo).FirstOrDefault();
                update = emprestimo;
                Commit();
                Close();
                return (Resultado.Ok(), update);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }

        }

        public Resultado Delete(Emprestimo emprestimo)
        {
            try
            {
                _context.Emprestimos.Remove(emprestimo);
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }

        }

        public (Resultado, List<Emprestimo>) GetByIdCliente(int idCliente)
        {
            try
            {
                List<Emprestimo> emprestimos = _context.Emprestimos.Where(at => at.IdCliente == idCliente).OrderByDescending(at => at.DataCadastro).ToList();
                Close();
                return (Resultado.Ok(), emprestimos);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        
        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    } //
}
