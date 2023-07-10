using ScreenSound.Model;
using Newtonsoft;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace ScreenSound.Controller{
    public class RegistrarBandaController{
        public static void Registrar(){
            Banda banda = new Banda();
            banda.nome = "Brenno";

            List<Banda> t2 = new List<Banda>();

            t2.Add(new Banda(){nome = "brenno"}); 
            t2.Add(new Banda(){nome = "t2"});

            string tt = JsonConvert.SerializeObject(banda);

            System.Console.WriteLine(tt);

            t2.ForEach(x => Console.WriteLine(x));
        }

        public static bool DoesNomeBandaExists(string nomeBanda){
            
            using (StreamReader r = new StreamReader("tt.json")){
                string jsonFile = r.ReadToEnd();

                List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonFile);

                if (bandas.Exists(elementos => String.Equals(elementos, nomeBanda))){
                    return true;
                }
                else{
                    return false;
                }
            }
            
        }

        public static bool ArquivoNomeBandaJsonExist(){

            if(File.Exists("bandas.json")){
                return true;
            }
            else{
                return false;
            }
        }
    }
}