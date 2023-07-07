namespace ScreenSound.View{
    public class RegistrarBanda{
        private string PerguntarBanda(){
            
            bool continuaPergunta = true;

            string nomeBanda = "";

            while (continuaPergunta == true){
                
                try {
                    
                    System.Console.Write("Digite o nome da banda a ser registrado: ");

                    nomeBanda = System.Console.ReadLine();

                }catch(Exception ex){
                    System.Console.WriteLine(ex.Message);
                }

            }

            return nomeBanda;
            
        }
    }
}