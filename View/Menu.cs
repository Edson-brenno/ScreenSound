// ScreenSounds Menu

//Menu exceptions:
using ScreenSound.Controller;
using ScreenSound.View.MenuException;

namespace ScreenSound.View{

    public class Menu{

        private void ApresentaMenu(){ //Write the name Menu; Escreve o nome menu
            System.Console.WriteLine(@"                      
                                    ██████████████████████████████
                                    █▄─▀█▀─▄█▄─▄▄─█▄─▀█▄─▄█▄─██─▄█
                                    ██─█▄█─███─▄█▀██─█▄▀─███─██─██
                                    ▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▄▄▄▄▀▀
            ");
        }

        private void MostraOpcoesMenu(){ //Show the menu options; Mostra as opções do menu

            System.Console.WriteLine("1. Registrar uma banda");
            System.Console.WriteLine("2. Mostrar bandas registradas");
            System.Console.WriteLine("3. Avaliar uma banda");
            System.Console.WriteLine("4. Ver média de uma banda");
            System.Console.WriteLine("5. Sair da ScreenSound");
        }

        private void EscolhaOpcaoMenu(){ // Menu choosed option; Escolha opção menu
            bool continuaEscolhaOpcao = true;
            string opcao = "";

            while(continuaEscolhaOpcao == true){
                
                try {

                    System.Console.Write("\n Digite a opção escolhida: ");

                    opcao = System.Console.ReadLine();

                    // Validations about the choosed option; Validação da opção escolhida
                    if (String.IsNullOrEmpty(opcao) || String.IsNullOrWhiteSpace(opcao)){
                        throw new NullOptionException();
                    }
                    else if (Char.IsBetween(char.ToLower(opcao[0]),'a','z') == true ){
                        throw new IsNotValidOptionException(opcao);
                    }
                    else if (Char.IsDigit(opcao[0]) == true && int.Parse(opcao) > 5) {
                        throw new IsNotValidOptionException(opcao);
                    }
                    else{
                        continuaEscolhaOpcao = false;
                    }
                }catch(Exception ex){
                    System.Console.WriteLine(ex.Message);
                }
                
            }

            switch(int.Parse(opcao)){
                case 1:
                    try{
                        RegistrarBandaView registroBanda = new RegistrarBandaView();
                        bool continua = true;

                        while(continua == true){

                            registroBanda.PerguntaNomeBanda();

                            if (!RegistrarBandaController.DoesNomeBandaExists(registroBanda.NomeBanda)){
                                continua = false;
                                registroBanda.SalvarNomeBanda();
                            }
                            else{
                                throw new BandaAlreadyExistException();
                            }                       
                        }
                    }
                    catch(Exception ex){
                        System.Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:

                    MostrarBandaView.ApresentaMenuBandas();

                    MostrarBandaView.MostrarBandas();
                    break;
                case 3:
                    AvaliarBandaView.ApresentaMenuAvaliacaoBanda();

                    AvaliarBandaView.MostrarOpcoesBandas();
                    break;
                case 4:
                    MediaBandaView.ApresentaMenuMediaBanda();

                    MediaBandaView.MostrarOpcoesBandas();
                    break;
                case 5:
                    System.Console.WriteLine("Tchau :)");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }

        }

        public void Main(){

            this.ApresentaMenu();

            this.MostraOpcoesMenu();

            this.EscolhaOpcaoMenu();
            
        }
    }
}