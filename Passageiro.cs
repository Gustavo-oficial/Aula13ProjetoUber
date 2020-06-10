namespace Aula13ProjetoUber
{
    public class Passageiro : Cartao
    {

        private string nomepassageiro = "Gustavo";
        public string Dadospassageiro
        {
            get { return nomepassageiro; }
            // set { myVar = value; }
        }
        
        //Procura de motorista ao redor
        public string SolicitarMotorista(){
            return "Procurando motoristas por perto...";
        }


        //Apos o motorista terminar a corrida, pagamento a ele sera realizada, caso ao contrario ficara pendente 
        public string Pagar( string statuscorrida){
            if(statuscorrida == "Corrida Finalizada"){
               return "Pagamento efetuado";
            }
             return "Corrida não finalizada";
        }
    }
}