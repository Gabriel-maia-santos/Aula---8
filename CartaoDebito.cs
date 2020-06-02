namespace Aula08Abstracao
{
    //Não ESQUECER DA HERANÇA
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }
        public string Tranferir(){
            return "Tranferência efetuada";
        }
        public string Pagartitulo(){
            return "Titulo pago";
        }
    }
}