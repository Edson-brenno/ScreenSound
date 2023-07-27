using ScreenSound.Controller;
namespace ScreenSound.View{

    public class MostrarBandaView{

        public static void ApresentaMenuBandas(){
            System.Console.Clear();

            System.Console.WriteLine(@"
                
    ███████████████████████████████████████
    █▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██─▄▄▄▄█
    ██─▄─▀██─▀─███─█▄▀─███─██─██─▀─██▄▄▄▄─█
    ▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀ " + "\n\n");
        }
        public static void MostrarBandas(){
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
                        System.Console.WriteLine(" 1 - Voltar Menu  3 - Sair");
                        System.Console.WriteLine("================================================");  
                        
            }
            else {
                int pagina = 4;
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
                        "\n         3 - Próxima Página  4 - Sair");
                        System.Console.WriteLine("================================================");  
                        continua = false;
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
                        System.Console.WriteLine(" 1 - Voltar Menu    2 - Página Anterior  3 - Sair");
                        System.Console.WriteLine("================================================");  
                        continua = false;
                    }
                
                }
                
            }
            
        }
    }
}