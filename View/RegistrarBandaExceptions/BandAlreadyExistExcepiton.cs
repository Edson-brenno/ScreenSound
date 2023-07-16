class BandaAlreadyExistException:Exception{
    public BandaAlreadyExistException(){
        System.Console.WriteLine("Banda já cadastrada no sistema!");
    }
    
    public BandaAlreadyExistException(string mensagem):base(mensagem){}
}