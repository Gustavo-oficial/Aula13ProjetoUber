using System;

namespace Aula13ProjetoUber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            Motorista carro = new Motorista();
            Passageiro viajante = new Passageiro();
            Corrida viagem =  new Corrida();
            Cartao visa = new Cartao();
            Pagamento forma = new Pagamento();

            viagem.localinicio = "Rua Japão, 96";
            viagem.localchegada = "Shopping São Caetano";
            viagem.statuscorrida = "Corrida Finalizada";

            System.Console.WriteLine("Seja Bem vindo(a)!");


            //Condição para saber acessar o campo de motorista ou de passageiro
            System.Console.WriteLine("Deseja fazer login como motorista ou passageiro?");
            string conta = Console.ReadLine();
            Console.Clear();

            // Se for digitado Motorista, havera uma pergunta sobre 
            if(conta == "motorista" ){

                System.Console.WriteLine("Digite sua agencia:");
                string agencia = Console.ReadLine();

              //Confirmação da agencia
              if(agencia == "Uber"){
                  System.Console.WriteLine("Há uma corrida por perto deseja aceitar ou recusar?");
                string condição = Console.ReadLine();

                switch (condição)
                {
                    //Condição caso o motorista aceite a corrida
                    case "aceitar": System.Console.WriteLine(carro.AceitarPassageiro());
                        Console.Clear();

                        //Caso o ássageiro aceite a corrida sera mostrado no para o motorista os dados do passageiro
                        System.Console.WriteLine($"O passageiro {viajante.Dadospassageiro} se localiza em {viagem.localinicio}, com destino {viagem.localchegada}");
                        
                        System.Console.WriteLine("Corrida em andamento");

                        //Apos chegar no destino, o motorista deve encerrar a corrida para receber o pagamento
                        System.Console.WriteLine("Deseja encerrar a corrida para calcular o valor?");
                        string statuscorrida = Console.ReadLine();
                        Console.Clear();

                        switch (statuscorrida)
                        {
                           //Apertando sim, a corrida é finalizada, e o motorista recebe o pagamento
                            case "sim": System.Console.WriteLine(viagem.statuscorrida);
                            System.Console.WriteLine(carro.ReceberPagamento(viagem.statuscorrida));
                            break;

                            //Se o motorista não tiver chegado no destino deve recusar encerrar a corrida
                            case "não": System.Console.WriteLine(forma.Status());
                            break;
                            
                            default:System.Console.WriteLine("Opção invalida!");
                            break;
                        }

    

                    break;

                   //Condição caso o motorista recuse a corrida
                    case "recusar": System.Console.WriteLine(carro.RecusarPassageiro());
                    System.Console.WriteLine("Procurando outro passageiro...");
                    break;

                    default: System.Console.WriteLine("");
                    break;
                }
              }else{
                  System.Console.WriteLine("Agencia inexistente");
              }

            }else{

            //Se for digitado passageiro, sera redirecionado para o campo de login de passageiro
            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
             Console.Clear();

            //Verificação de senha e usuario
            if(user.senha == senha && user.login == login){

                Console.WriteLine("Voce está logado!");
               

                //Condição para saber se deseja fazer a uma viagem ou não
                System.Console.WriteLine("Deseja fazer uma viagem?");
                string LocalizaçãoAtual = Console.ReadLine();

                if(LocalizaçãoAtual == "sim" ){

                //Gera informação da localização do passageiro
                System.Console.WriteLine("Digite o seu localização:");
                string localinicio = Console.ReadLine();
  
                //Gera informação do destino do passageiro
                System.Console.WriteLine("Digite seu destino:");
                string localchegada = Console.ReadLine();
                Console.Clear();

                // Digitando o destino o aplicativo vai procurar um motorista disponivel nas proximidades
                   System.Console.WriteLine(viajante.SolicitarMotorista());
                   System.Console.WriteLine("Um motorista foi encontrado nas proximidades, se deseja aceitar aperte 1, caso deseje cancelar aperte 2;");
                   string SolicitarMotorista = Console.ReadLine();

                   switch (SolicitarMotorista)
                   {
                       //Caso o passageiro aceite a corrida, sera mostrado na tela os dados da viagem
                       case "1": System.Console.WriteLine($"O nome do motorista é {carro.Dadosmotorista}e o carro é um {carro.Dadoscarro} com placa {carro.Dadosplaca}");
                       

                      System.Console.WriteLine("Voce chegou ao seu destino!");


                      //Achando o motorista, o passageiro deve selecionar sua forma de pagamento
                       System.Console.WriteLine("Se deseja cadastrar o seu cartão como forma de pagamento aperte 1 \n Para excluir um cartão digite 2 \n Para outra forma de pagamento digite 3");
                       string cartão = Console.ReadLine();
                       Console.Clear();


                           switch (cartão)
                           {
                               //Apos a corrida ser finalizada e a forma de pagamento ser selecionada, o pagamento é efetuado
                               case "1": System.Console.WriteLine(visa.Cadastrar());
                               System.Console.WriteLine(viagem.statuscorrida);
                               System.Console.WriteLine(viajante.Pagar(viagem.statuscorrida));
                               break;

                               case "2":System.Console.WriteLine(visa.Excluir());
                               break;

                                case "3":System.Console.WriteLine("Outra forma de pagamento sera utilizada!");
                                System.Console.WriteLine(viagem.statuscorrida);
                                System.Console.WriteLine(viajante.Pagar(viagem.statuscorrida));
                               break;


                               default:System.Console.WriteLine("Opção invalida!");
                               break;
                           }
                       break;

                       
                       //Caso o passageiro não aceite a viagem ela seria cancelada
                       case "2":System.Console.WriteLine(viagem.Cancelar());
                       break;
                       
                       default: System.Console.WriteLine("Digite uma opção valida!");
                       break;
                   }


                }else{
                    System.Console.WriteLine("");
                }
            }else{
                //Mensagem mostrada caso a senha e usuario não forem corretas.
                Console.WriteLine("Senha ou usuario incorreto");
            }
            }  
        }
    }
}
