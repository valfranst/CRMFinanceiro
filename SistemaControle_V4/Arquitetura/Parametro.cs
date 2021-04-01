using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControle_V4
{
    public class Parametro
    {
        public MainPage mainPage { get; set; }
        public int IdCliente { get; set; }
        public int IdEmprestimo { get; set; }
        public int IdParcela { get; set; }

        public Parametro(MainPage mainPage, int IdCliente, int IdEmprestimo, int IdParcela)
        {
            this.mainPage = mainPage;
            this.IdCliente = IdCliente;
            this.IdEmprestimo = IdEmprestimo;
            this.IdParcela = IdParcela;
        }

    } //***************
}
