using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            if (atendente is null)
            {
                return (Resultado.Erro("O Atendente é nulo!"), null);
            }
            else if (atendente.IdAtendente > 0)
            {
                return (Resultado.Erro("IdAtendente não deve está preenchido para INSERIR!"), null);
            }
            else if (atendente.NomeAtendente.Length > 100)
            {
                return (Resultado.Erro("O Nome do Atendente não pode ter mais que 100 caracteres!"), null);
            }
            else if (atendente.NomeAtendente is null)
            {
                return (Resultado.Erro("O Nome do Atendente deve está preenchido!"), null);
            }
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
            if (atendente is null)
            {
                return (Resultado.Erro("O Atendente é nulo!"), null);
            }
            else if (atendente.IdAtendente <= 0)
            {
                return (Resultado.Erro("IdAtendente não está preenchido!"), null);
            }
            else if (atendente.NomeAtendente.Length > 100)
            {
                return (Resultado.Erro("O Nome do Atendente não pode ter mais que 100 caracteres!"), null);
            }
            else if (atendente.NomeAtendente is null)
            {
                return (Resultado.Erro("O Nome do Atendente deve está preenchido!"), null);
            }
            try
            {
                Atendente update = _context.Atendentes.Where(at =>at.IdAtendente == atendente.IdAtendente).FirstOrDefault();
                _context.Atendentes.Add(update);
                Commit();
                Close();
                return (Resultado.Ok(), update);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }

        }

        public Resultado Delete(Atendente atendente)
        {
            if (atendente is null)
            {
                return Resultado.Erro("O Atendente é nulo!");
            }
            else if (atendente.IdAtendente <= 0)
            {
                return Resultado.Erro("IdAtendente não está preenchido!");
            }
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

        public (Resultado, Atendente) GetAtendenteById(int id)
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

        public (Resultado, Atendente) GetAtendenteByNome(string nome)
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
