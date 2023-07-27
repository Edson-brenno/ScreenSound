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
            }
            else {
                int pagina = 2;
                bool continua = true;

                while(continua == true){
                    if (mostrarBandas.TotalRegistros() > 3 * pagina){
                        mostrarBandas.Mostrar(pagina);
                        System.Console.WriteLine(
                            "\n" +
                            $"       Página {pagina}  \nMostrando {pagina * 3} de {mostrarBandas.TotalRegistros()} registros..." +
                            "\n" 
                            );    
                        continua = false;
                    }
                    else{
                        mostrarBandas.Mostrar(pagina);
                        System.Console.WriteLine("Pagina Anterior");
                    }
                
                }
                
            }
            
        }
    }
}