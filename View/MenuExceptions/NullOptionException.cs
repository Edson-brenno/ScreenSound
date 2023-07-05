// This exception will be used if the user doesn't chosed one option; Este exception vai ser usado caso o usuário não escolha uma opção
namespace ScreenSound.View.MenuException{
    public class NullOptionException : Exception{
        public NullOptionException(){
            System.Console.WriteLine("Uma opção do menu deve ser escolhida!");
        }

        public NullOptionException(string message) : base(message){}
    }
}