using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControle_V3
{
    class ViewRefinanciarModel
    {

        private readonly RepresaContext _context;

        public ViewRefinanciarModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, List<ViewRefinanciar>) GetByPeriodoRef(DateTime inicio, DateTime fim)
        {
            try
            {
                List<ViewRefinanciar> refinanciamentos = _context.ViewRefinanciars.Where(vr => (vr.UltimaParcela >= inicio && vr.UltimaParcela <= fim && vr.ReferenciaEmprestimo == "0")).OrderBy(vr => vr.UltimaParcela).ToList();
                Close();
                return (Resultado.Ok(), refinanciamentos);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, List<ViewRefinanciar>) GetByPeriodo(DateTime inicio, DateTime fim)
        {
            try
            {
                List<ViewRefinanciar> refinanciamentos = _context.ViewRefinanciars.Where(vr => (vr.UltimaParcela >= inicio && vr.UltimaParcela <= fim && vr.ReferenciaEmprestimo == null)).OrderBy(vr => vr.UltimaParcela).ToList();
                Close();
                return (Resultado.Ok(), refinanciamentos);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    } //
}
