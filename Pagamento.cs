using System;

namespace Aula13ProjetoUber

{
    public class Pagamento : Passageiro
    {
        public DateTime data { get; set; }


        //Se a corrida não for finalizada, o pagamento ficara pendente
        public string Status(){
            return "Corrida Pendente";
        }
    }
}