// This Exception will be called if the user doesn't use a number between 0 and 10; Esta excessão vai ser usada caso o usuário use uma nota que não esteja entre 0 e 10
namespace ScreenSound.ExceptionAvaliarBanda{
    public class GradeIsHigherOrLessException:Exception{
        public GradeIsHigherOrLessException(){
            System.Console.WriteLine("Error! A nota deve estar entre 0 e 10");
        }

        public GradeIsHigherOrLessException(string mensagem):base(mensagem){}
         
    }
}