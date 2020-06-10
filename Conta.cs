namespace Aula13ProjetoUber
{
    public class Conta 
    {
        //Validação para fazer login
        public string agencia = "Uber";

        public string conta;


        //Após validação, o motorista pode ser cadastrado
        public string CadastrarConta(){
            return "Conta Cadastrada!";
        }
        public string ExcluirConta(){
            return "Conta excluida";
    }
        }
}