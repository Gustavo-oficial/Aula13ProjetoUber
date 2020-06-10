namespace Aula13ProjetoUber
{
    public class Motorista : Conta
    {
       private string carro = "Celta";
       public string Dadoscarro
       {
           get { return carro; }
        //    set { myVar = value; }
       }
       

        private string nomemotorista = "Cleber";
        public string Dadosmotorista
        {
            get { return nomemotorista;}
            // set { myVar = value; }
        }
        

        private string placa = "GHG 8976";
        public string Dadosplaca
        {
            get { return placa; }
            // set { myVar = value; }
        }
        
        public string condição;

        public string AceitarPassageiro(){
            return "Corrida aceita";
        }

        public string RecusarPassageiro(){
            return "Corrida recusada";
        }

        //Finalizando a corrida, o mnotorista recebera o pagamento do passageiro
        public string ReceberPagamento(string statuscorrida){
            if(statuscorrida =="Corrida Finalizada"){
                return "O pagamento foi recebido";
            }
                return "Pagamento do pasageiro pendente";
        }
    }
}