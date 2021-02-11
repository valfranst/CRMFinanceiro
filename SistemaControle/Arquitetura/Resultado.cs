using System;

namespace SistemaControle.Arquitetura
{
    public class Resultado
    {

        public bool estado { get; }
        public string mensagem { get; }

        private Resultado(string mensagem)
        {
            this.estado = false;
            this.mensagem = mensagem;
        }
        private Resultado()
        {
            this.estado = true;
            this.mensagem = null;
        }

        public static  Resultado Ok()
        {
            return new Resultado();
        }
        public static Resultado Erro(string mensagem)
        {
            return new Resultado(mensagem);
        }

    } //fim class
}
