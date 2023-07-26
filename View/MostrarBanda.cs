using ScreenSound.Controller;
namespace ScreenSound.View{

    public class MostrarBandaView{
        public static void MostrarBandas(){
            MostrarBandaController mostrarBandas = new MostrarBandaController();

            if (mostrarBandas.TotalRegistros() == 0){
                System.Console.WriteLine("Não Possui Bandas Cadastradas");
            }
            else if (mostrarBandas.TotalRegistros() <= 3){
                mostrarBandas.Mostrar(1);
            }
            else {
                int pagina = 4;
                if (mostrarBandas.TotalRegistros() > 3 * pagina){
                    mostrarBandas.Mostrar(pagina);
                    System.Console.WriteLine("Proxima página");    
                }
                else{
                    mostrarBandas.Mostrar(pagina);
                    System.Console.WriteLine("Pagina Anterior");
                }
                
            }
            
        }
    }
}