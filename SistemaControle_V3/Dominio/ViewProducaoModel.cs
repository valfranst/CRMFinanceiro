﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaControle_V3.Model
{
    class ViewProducaoModel
    {

        private readonly RepresaContext _context;

        public ViewProducaoModel()
        {
            _context = new RepresaContext();
        }

        public (Resultado, List<ViewProducao>) GetByPeriodo(DateTime inicio, DateTime fim)
        {
            try
            {
                List<ViewProducao> producoes = _context.ViewProducaos.Where(at => at.DataCadastro >= inicio && at.DataCadastro <= fim).OrderBy(ce => ce.CodOrder).ToList();
                Close();
                return (Resultado.Ok(), producoes);
            }
            catch (Exception e) { return (Resultado.Erro("Erro \n\n" + e), null); }
            finally { Close(); }
        }

        private void Commit() => _context.SaveChanges();
        private void Close() => _context.Dispose();

    } //
}
