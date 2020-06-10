namespace Aula13ProjetoUber
{
    public class Usuario
    {
        public string login = "gustavo@gmail.com";

        public string senha = "1234";

        public string nome{ get; set; }
        public string foto { get; set; }
        public string LocalizaçãoAtual { get; set; }
        public string TokenDeLogin = "udsbffghbfvbjfvjnn";

         // Havera uma verificação na veracidade do usuario e senha, caso esteja errado o usuario nao sera logado
        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha){
                return true;
            }
               return false;
        }
         public void Logout(){
            TokenDeLogin = "" ;
        }
    }
}