using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
           CartaoCredito visa = new CartaoCredito();
           visa.limite = 3000f;
           System.Console.WriteLine("Deseja aumentar seu limite de cartão de credito? Quanto de acréscimo?");
           float acrescimo = float.Parse(Console.ReadLine() );

           visa.AumentarLimite(acrescimo);
           Console.WriteLine("novo limite: R$" +visa.limite);

           System.Console.WriteLine("digite a data do pagamento:");
           visa.data = DateTime.Parse(Console.ReadLine() );
           System.Console.WriteLine("Data: "+visa.data);
           
    }
 }
}
