using ScreenSound.Controller;

namespace ScreenSound.View{

    public class EscolhaBanda{
        
        public static int bandaIndice;

        public static void PerguntaBandaEscolhida(){
            
        }
    }
    public class AvaliarBandaView{
        public static void ApresentaMenuAvaliacaoBanda(){
            System.Console.Clear();

            System.Console.WriteLine(@"
                
    
██████████████████████████████████████████████████████████████████████████████████████
██▀▄─██▄─█─▄██▀▄─██▄─▄███▄─▄██▀▄─██─▄▄▄─██▀▄─██─▄▄─███▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██
██─▀─███▄▀▄███─▀─███─██▀██─███─▀─██─███▀██─▀─██─██─████─▄─▀██─▀─███─█▄▀─███─██─██─▀─██
▀▄▄▀▄▄▀▀▀▄▀▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀ " + "\n\n");
        }

        public static void MostrarOpcoesBandas(){

            MostrarBandaController mostrarBandas = new MostrarBandaController();

            if (mostrarBandas.TotalRegistros() == 0){
                System.Console.WriteLine("Não Possui Bandas Cadastradas");
            }
            else if (mostrarBandas.TotalRegistros() <= 3){
                mostrarBandas.Mostrar(1);

                System.Console.WriteLine(
                            "\n" +
                            $"                     Página {1}" + 
                            $"\n          Mostrando {1} de {mostrarBandas.TotalRegistros()} registros..." +
                            "\n" 
                            );  

                System.Console.WriteLine("================================================");
                System.Console.WriteLine(" 1 - Voltar Menu  2 - Escolher Banda 3 - Sair");
                System.Console.WriteLine("================================================");

                System.Console.Write("Digite a opção escolhida: ");
                string op = System.Console.ReadLine(); 

                switch(int.Parse(op)){
                            case 1:
                                Menu menu = new Menu();

                                System.Console.Clear();

                                menu.Main();

                            break;
                            case 2:
                            
                            break;
                            case 3:
                                System.Environment.Exit(0);
                            break;
                            default:
                                System.Environment.Exit(0);
                            break;
                        } 
                        
            }
            else {
                int pagina = 1;
                bool continua = true;

                while(continua == true){
                    if (mostrarBandas.TotalRegistros() > 3 * pagina){
                        mostrarBandas.Mostrar(pagina);

                        System.Console.WriteLine(
                            "\n" +
                            $"                     Página {pagina}" + 
                            $"\n          Mostrando {pagina * 3} de {mostrarBandas.TotalRegistros()} registros..." +
                            "\n" 
                            );  

                        System.Console.WriteLine("================================================");
                        System.Console.WriteLine("         1 - Voltar Menu     2 - Página Anterior" + 
                        "\n         3 - Próxima Página  4 - Escolher uma banda" + "\n          5 - Sair");
                        System.Console.WriteLine("================================================");
                        System.Console.Write("Digite a opção escolhida: ");
                        string op = System.Console.ReadLine(); 

                        switch(int.Parse(op)){
                            case 1:
                                continua = false;

                                Menu menu = new Menu();

                                System.Console.Clear();

                                menu.Main();

                            break;
                            case 2:
                                pagina -= 1;

                                System.Console.Clear();
                            break;
                            case 3:
                                pagina += 1;

                                System.Console.Clear();
                            break;
                            case 4:
                                continua = false;
                            break;
                            default:
                                continua = false;
                            break;
                        }
                    }
                    else{
                        mostrarBandas.Mostrar(pagina);

                        System.Console.WriteLine(
                            "\n" +
                            $"                     Página {pagina}" + 
                            $"\n          Mostrando {pagina * 3} de {mostrarBandas.TotalRegistros()} registros..." +
                            "\n" 
                            );  

                        System.Console.WriteLine("================================================");
                         System.Console.WriteLine("         1 - Voltar Menu     2 - Página Anterior" + 
                        "\n         3 - Escolher uma banda  4 - Sair");
                        System.Console.WriteLine("================================================");
                        System.Console.Write("Digite a opção escolhida: ");
                        string op = System.Console.ReadLine(); 

                        switch(int.Parse(op)){
                            case 1:
                                Menu menu = new Menu();

                                System.Console.Clear();

                                menu.Main();

                            break;
                            case 2:
                                pagina -= 1;

                                System.Console.Clear();
                            break;
                            case 3:
                                continua = false;
                            break;
                            default:
                                continua = false;
                            break;
                        }
                    }
                
                }
                
            }
            
        }
    }
}