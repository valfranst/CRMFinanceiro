using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControle_V3
{
    class ViewRecebimentoModel
    {

        private readonly RepresaContext _context;

        public ViewRecebimentoModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, List<ViewRecebimento>) GetByPeriodo(DateTime inicio, DateTime fim)
        {
            try
            {
                List<ViewRecebimento> recebimentos = _context.ViewRecebimentos.Where(vr => (vr.Vencimento >= inicio && vr.Vencimento <= fim)).OrderBy(vr => vr.CodOrder).ToList();
                Close();
                return (Resultado.Ok(), recebimentos);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    }//
}
