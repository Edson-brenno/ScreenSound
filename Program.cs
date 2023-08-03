using System;
using ScreenSound.Configuracao;
using ScreenSound.View;

namespace ScreenSound{
    public class ScreenSound{
        public static void Main(){
            
            try{
                
                // Check if the necessaries archives already exists; Verifica se os arquivos necessarios existem;
                if (!ConfiguracaoScreenSound.JaFoiConfigurado()){
                    // Confegure the system; Configura o sistema para rodar
                    ConfiguracaoScreenSound.Configurar();
                }

                //Screen Sound Apresentation; Screen Sound Apresentação
                ApresentacaoScreenSound.EscreveScreenSound();

                //Menu Screen Sound; Menu screen sound
                Menu menu = new Menu();

                menu.Main();
            }
            catch(Exception e){

                Console.WriteLine(e);

            }
        }
    }
}