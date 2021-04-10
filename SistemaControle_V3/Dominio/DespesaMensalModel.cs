using System;
using System.Linq;

namespace SistemaControle_V3
{
    class DespesaMensalModel
    {
        private readonly RepresaContext _context;
        public DespesaMensalModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, DespesaMensal) Insert(DespesaMensal despesa)
        {
            try
            {
                _context.DespesaMensals.Add(despesa);
                Commit();
                Close();
                return (Resultado.Ok(), despesa);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, DespesaMensal) Update(DespesaMensal despesa)
        {
            try
            {
                DespesaMensal update = _context.DespesaMensals.Where(at => at.IdDespesaMensal == despesa.IdDespesaMensal).FirstOrDefault();
                update = despesa;
                Commit();
                Close();
                return (Resultado.Ok(), update);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();


    } //
}
