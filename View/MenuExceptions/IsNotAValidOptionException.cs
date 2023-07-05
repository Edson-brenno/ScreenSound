// Invalid menu option exception; Opção do menu inválida
namespace ScreenSound.View.MenuException{
    public class IsNotValidOptionException : Exception{
        public IsNotValidOptionException(){
            System.Console.WriteLine("Opção Inválida");
        }

        public IsNotValidOptionException(string message) : base($"A opção {message} é inválida"){}
    }
}