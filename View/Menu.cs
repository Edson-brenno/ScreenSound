// ScreenSounds Menu

using System.Runtime.InteropServices;

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
        }

        public void Main(){

            this.ApresentaMenu();

            this.MostraOpcoesMenu();
            
        }
    }
}