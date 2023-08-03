// This exception will be used if the user does not passe the grade; Este exception vai ser usado caso o usuário não passe a nota
namespace ScreenSound.ExceptionAvaliarBanda{
    public class AvaliarBandaException : Exception{
        public AvaliarBandaException(){
            System.Console.WriteLine("A nota da banda não pode ser nula");
        }

        public AvaliarBandaException(string mensagem):base(mensagem){}
    }
}