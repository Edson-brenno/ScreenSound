using System.Dynamic;
using ScreenSound.Controller;
using ScreenSound.View.Exceptions;

namespace ScreenSound.View{
    public class RegistrarBandaView{

        public string NomeBanda {get;set;}
        public void PerguntaNomeBanda(){
            
            bool continuaPergunta = true;

            while (continuaPergunta == true){
                
                try {
                    
                    System.Console.Write("Digite o nome da banda a ser registrado: ");

                    string nome = System.Console.ReadLine();

                    if (String.IsNullOrEmpty(nome) || String.IsNullOrWhiteSpace(nome)){
                        throw new IsNUllException();
                    }
                    else{
                        this.NomeBanda = nome;
                        continuaPergunta = false;
                    }

                }catch(Exception ex){
                    System.Console.WriteLine(ex.Message);
                }

            }            
        }


        public void SalvarNomeBanda(){
            
            RegistrarBandaController.Registrar(this.NomeBanda);
        }

    }
}