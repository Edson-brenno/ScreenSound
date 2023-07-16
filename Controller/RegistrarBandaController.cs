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

        public static bool DoesNomeBandaExists(string nomeBanda){ // Will check if the bands name already exists; Vai verificar se a banda já está registrada
            
            try{
                // Read the bands json; Leitura do json das bandas
                using (StreamReader r = new StreamReader("bandas.json")){
                    string jsonFile = r.ReadToEnd();

                    //Deserialize json; Descerialização do json
                    List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonFile);

                    // Verify if the json is already populated; verifica se o json possui algum dado
                    if (bandas != null && bandas.Count > 0){
                        // Check the bands name already exist; verifi se o nome da banda existe
                        if (bandas.Contains(new Banda{nome = nomeBanda})){
                            return true;
                        }
                        else{
                            return false;
                        }
                    }
                    // If the jason does not have value; Se o json não possui dados
                    else{
                        return false;
                    }
                }
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
                return false;
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