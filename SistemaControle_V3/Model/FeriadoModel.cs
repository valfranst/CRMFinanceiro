using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControle_V3
{
    class FeriadoModel
    {

        private readonly RepresaContext _context;

        public FeriadoModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, Feriado) Insert(Feriado feriado)
        {
            try
            {
                _context.Feriados.Add(feriado);
                Commit();
                Close();
                return (Resultado.Ok(), feriado);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public Resultado InsertAll(List<Feriado> feriados)
        {
            try
            {
                _context.Feriados.AddRange(feriados);
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }
        }


        public (Resultado, Feriado) Update(Feriado feriado)
        {
            try
            {
                Feriado update = _context.Feriados.Where(at => at.IdFeriado == feriado.IdFeriado).FirstOrDefault();
                update = feriado;
                Commit();
                Close();
                return (Resultado.Ok(), update);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }

        }

        public Resultado Delete(Feriado feriado)
        {
            try
            {
                _context.Feriados.Remove(feriado);
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }

        }

        public (Resultado, Feriado) GetByData(DateTime data)
        {
            try
            {
                Feriado feriado = _context.Feriados.Where(at => at.DataFeriado == data).FirstOrDefault();
                Close();
                return (Resultado.Ok(), feriado);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, List<Feriado>) GetAll()
        {
            try
            {
                List<Feriado> feriados = _context.Feriados.OrderByDescending(at => at.DataFeriado).ToList();
                Close();
                return (Resultado.Ok(), feriados);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }


        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    } //
}
