using System;

namespace Aula08Abstracao
{
    //não esquecer da herança
    public class boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codDeBarras { get; set; }
        public string Registrar(){
            return "Boleto registrado com sucesso!";
        }
        
    }
}