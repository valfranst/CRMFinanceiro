using System;
using System.Linq;

#nullable disable

namespace SistemaControle_V3
{

    public class AtendenteModel
    {
        private readonly RepresaContext _context;

        public AtendenteModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, Atendente) Insert(Atendente atendente)
        {
            try
            {
                _context.Atendentes.Add(atendente);
                Commit();
                Close();
                return (Resultado.Ok(), atendente);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, Atendente) Update(Atendente atendente)
        {
            try
            {
                Atendente update = _context.Atendentes.Where(at => at.IdAtendente == atendente.IdAtendente).FirstOrDefault();
                update = atendente;
                Commit();
                Close();
                return (Resultado.Ok(), update);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }

        }

        public Resultado Delete(Atendente atendente)
        {
            try
            {
                _context.Atendentes.Remove(atendente);
                Commit();
                Close();
                return Resultado.Ok();
            }
            catch (Exception e) { return Resultado.Erro("Erro \n\n" + e); }
            finally { Close(); }

        }

        public (Resultado, Atendente) GetById(int id)
        {
            try
            {
                Atendente atendente = _context.Atendentes.Where(at => at.IdAtendente == id).FirstOrDefault();
                Close();
                return (Resultado.Ok(), atendente);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        public (Resultado, Atendente) GetByNome(string nome)
        {
            try
            {
                Atendente atendente = _context.Atendentes.Where(at => at.NomeAtendente == nome).FirstOrDefault();
                Close();
                return (Resultado.Ok(), atendente);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }


        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    }//*****************
}
