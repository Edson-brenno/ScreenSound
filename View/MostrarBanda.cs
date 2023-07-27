using ScreenSound.Controller;
namespace ScreenSound.View{

    public class MostrarBandaView{

        public static void ApresentaMenuBandas(){
            System.Console.Clear();
            
            System.Console.WriteLine(@"
                ███████████████████████████████████████████████████████████████████████████████████████████████████████
                █─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀███▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██─▄▄▄▄█
                █▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀█▄▄▄▄─█─██─██─██─███─█▄▀─███─██─████─▄─▀██─▀─███─█▄▀─███─██─██─▀─██▄▄▄▄─█
                ▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀");
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
                        System.Console.WriteLine($"Pág {pagina - 1} | {pagina} | {pagina + 1}      {pagina * 3} registros de {mostrarBandas.TotalRegistros()}...");    
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