using System;
using ScreenSound.Configuracao;
using ScreenSound.View;

namespace ScreenSound{
    public class ScreenSound{
        public static void Main(){
            
            try{

                if (!ConfiguracaoScreenSound.JaFoiConfigurado()){
                    ConfiguracaoScreenSound.Configurar();
                }

                ApresentacaoScreenSound.EscreveScreenSound();

                Menu menu = new Menu();

                menu.Main();
            }
            catch(Exception e){

                Console.WriteLine(e);

            }
        }
    }
}