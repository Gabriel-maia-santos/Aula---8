using System;

namespace Aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public void AumentarLimite(float acrecimo){
            limite = limite + acrecimo;
        }

        internal void AumentarLimite()
        {
            throw new NotImplementedException();
        }

        internal void AumentarLimite(object acres)
        {
            throw new NotImplementedException();
        }
    }
}