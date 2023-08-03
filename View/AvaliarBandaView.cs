using ScreenSound.Controller;
using ScreenSound.View.MenuException;
using ScreenSound.ExceptionAvaliarBanda;
using ScreenSound.View.Exceptions;

namespace ScreenSound.View{

    public class Nota{

        public static double nota;
        public static void PerguntaNotaBanda(){
            
            bool continua = true;

            while(continua == true){
                    try{
                    System.Console.Write("Digite a nota da banda (0,10): ");
                    string notaDigitada = System.Console.ReadLine();

                    if(string.IsNullOrEmpty(notaDigitada)){
                        throw new IsNUllException();
                    }
                    else if (!char.IsDigit(notaDigitada[0])){
                        throw new IsStringException();
                    }
                    else if (char.IsDigit(notaDigitada[0]) && Convert.ToDouble(notaDigitada.Replace('.',',')) > 10){
                        throw new GradeIsHigherOrLessException();
                    }
                    else if (char.IsDigit(notaDigitada[0]) && Convert.ToDouble(notaDigitada.Replace('.',',')) < 0){
                        throw new GradeIsHigherOrLessException();
                    }
                    else{
                        nota = Convert.ToDouble(notaDigitada.Replace('.',','));
                        continua = false;
                    }
                }catch(Exception ex){
                    System.Console.WriteLine(ex.Message);
                }
            }
            
            
            
            
        }
    }

    public class EscolhaBanda{
        
        public static int bandaIndice;

        public static void PerguntaBandaEscolhida(int totalRegistros){
            try{
                System.Console.WriteLine("================================================");
                System.Console.Write("Digite o indice da banda escolhida: ");
                string bandaEscolhida = System.Console.ReadLine();
                
                // Validation of the chosen band; Validação da banda escolhida
                if(string.IsNullOrEmpty(bandaEscolhida)){
                    throw new IsNotValidOptionException("Error! Digite o indice da banda");
                }
                else if (!Char.IsDigit(bandaEscolhida[0])){
                    throw new IsNotValidOptionException("Error! O indice da banda não pode ser letra");
                }
                else if (Char.IsDigit(bandaEscolhida[0]) && Convert.ToInt32(bandaEscolhida) > totalRegistros){
                    throw new IsNotValidOptionException("Error! Indice inválido");
                }
                else if (Char.IsDigit(bandaEscolhida[0]) && Convert.ToInt32(bandaEscolhida) <= 0){
                    throw new IsNotValidOptionException("Error! Indice inválido");
                }
                else{
                    bandaIndice = Convert.ToInt32(bandaEscolhida);
                }
            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
                System.Environment.Exit(0);
            }
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
                                EscolhaBanda.PerguntaBandaEscolhida(mostrarBandas.TotalRegistros());

                                Nota.PerguntaNotaBanda();

                                AvaliarBandaController.AvaliarBanda(EscolhaBanda.bandaIndice, Nota.nota);
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