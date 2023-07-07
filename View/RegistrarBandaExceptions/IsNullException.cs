namespace ScreenSound.View.Exceptions{
    class IsNUllException : Exception{
        public IsNUllException(){
            System.Console.WriteLine("O nome da banda não pode ser nulo");
        }

        public IsNUllException(string mensagem):base(mensagem){}
    }
}