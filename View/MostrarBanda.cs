using ScreenSound.Controller;
namespace ScreenSound.View{

    public class MostrarBandaView{
        public static void MostrarBandas(){
            MostrarBandaController mostrarBandas = new MostrarBandaController();

            if (mostrarBandas.TotalRegistros() == 0){
                System.Console.WriteLine("Não Possui Bandas Cadastradas");
            }
            else if (mostrarBandas.TotalRegistros() == 1){
                mostrarBandas.Mostrar();
            }
            else {
                mostrarBandas.Mostrar();
            }
            
        }
    }
}