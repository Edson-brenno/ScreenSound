// This exception will be used if the user does uses a string; Este exception vai ser usado caso o usuário use uma string
namespace ScreenSound.ExceptionAvaliarBanda{
    public class IsStringException:Exception{
        public IsStringException(string message):base(message){}

        public IsStringException(){
            System.Console.WriteLine("Utilize apenas números para a nota");
        }
    }
}