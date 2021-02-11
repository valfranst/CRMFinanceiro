using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControle.Arquitetura
{
    class Espelho
    {
        public string Acao { get; set; }
        public Type Tipo { get; set; }
        public string Dado { get; set; }
        public DateTime DataCadastro;

        public Espelho()
        {
            DataCadastro = DateTime.Now;
        }

        } //********************************************
}
