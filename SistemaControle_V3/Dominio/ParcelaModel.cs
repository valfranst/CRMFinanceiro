using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaControle_V3
{
    class ParcelaModel
    {

        private readonly RepresaContext _context;

        public ParcelaModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, Parcela) Insert(Parcela parcela)
        {
            try
            {
                _context.Parcelas.Add(parcela);
                Commit();
                Close();
                return (Resultado.Ok(), parcela);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, Parcela) Update(Parcela parcela)
        {
            try
            {
                Parcela update = _context.Parcelas.Where(at => at.IdParcela == parcela.IdParcela).FirstOrDefault();
                update = parcela;
                Commit();
                Close();
                return (Resultado.Ok(), parcela);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }

        }

        public Resultado Delete(Parcela parcela)
        {
            try
            {
                _context.Parcelas.Remove(parcela);
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }

        }

        public (Resultado, List<Parcela>) GetByIdEmprestimo(int idEmprestimo)
        {
            try
            {
                List<Parcela> parcelas = _context.Parcelas.Where(at => at.IdEmprestimo == idEmprestimo).OrderByDescending(at => at.Vencimento).ToList();
                Close();
                return (Resultado.Ok(), parcelas);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    } //
}
