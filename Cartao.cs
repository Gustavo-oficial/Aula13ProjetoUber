namespace Aula13ProjetoUber
{
    public class Cartao
    {
        public string numero { get; set; }

        public string titular { get; set; }

        public string bandeira { get; set; }

        public string cvv { get; set; }

        public string cartão;

        public string Cadastrar(){
            return "Cartão registrado!";
        }
        public string Excluir(){
            return "Cartão excluido";
        }
    }
}