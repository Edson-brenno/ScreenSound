using ScreenSound.Model;
using Newtonsoft;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.IO.Compression;

namespace ScreenSound.Controller{
    public class RegistrarBandaController{
        public static void Registrar(string nomeBanda){
            
            string jsonFile = "";

            using (StreamReader sr = new StreamReader("bandas.json")){
                //Read the json file till the end; Lê o arquivo json todo
                jsonFile = sr.ReadToEnd();
            }
            //If the json has already more than 1 band registred; Se o json tem mais de uma banda registrada
            if(jsonFile.StartsWith("[")){
                
                //Deserialize the json; Descerializa o json
                List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonFile);

                // Add the new band to the list; Adiciona uma nova banda na lista
                bandas.Add(new Banda(){nome = nomeBanda.ToUpper()});

                //Serialize the new json; Serializa o novo json
                string jsonAtualizado = JsonConvert.SerializeObject(bandas);
                
                //Write the json
                using (StreamWriter sw = new StreamWriter("bandas.json")){

                    sw.Write(jsonAtualizado);
                }
            }
            // If the json only have one band; Se o json tem apenas uma banda
            else{
                
                if(!String.IsNullOrEmpty(jsonFile)){
                    //Deserialize the json; Descerializa o json
                    Banda bandaJson = JsonConvert.DeserializeObject<Banda>(jsonFile);

                    // list of the bands; Lista das bandas 
                    List<Banda> bandas = new List<Banda>();

                    // Add value of the json to the list; Adiciona valor do json para a lista
                    bandas.Add(bandaJson);

                    // Add the new band to the list; Adiciona a nova banda para a lista
                    bandas.Add(new Banda(){nome = nomeBanda.ToUpper()});

                    //Serialize the updated json; Serializa o json atualizado
                    string jsonAtualizado = JsonConvert.SerializeObject(bandas);

                    //Write the updated json; Escreve o novo json
                    using (StreamWriter sw = new StreamWriter("bandas.json")){
                        sw.Write(jsonAtualizado);
                    }
                }
                else{
                    
                    // list of the bands; Lista das bandas 
                    List<Banda> bandas = new List<Banda>();

                    // Add the new band to the list; Adiciona a nova banda para a lista
                    bandas.Add(new Banda(){nome = nomeBanda.ToUpper()});

                    //Serialize the updated json; Serializa o json atualizado
                    string jsonAtualizado = JsonConvert.SerializeObject(bandas);

                    //Write the updated json; Escreve o novo json
                    using (StreamWriter sw = new StreamWriter("bandas.json")){
                        sw.Write(jsonAtualizado);
                    }
                }
            } 
        }

        public static bool DoesNomeBandaExists(string nomeBanda){ // Will check if the bands name already exists; Vai verificar se a banda já está registrada
            
            try{
                // Read the bands json; Leitura do json das bandas
                using (StreamReader r = new StreamReader("bandas.json")){
                    //Read the json to End
                    string jsonFile = r.ReadToEnd();

                    //If the json has already more than 1 band registred; Se o json tem mais de uma banda registrada
                    if (jsonFile.StartsWith("[") == true){
                        System.Console.WriteLine("Chegou errado");
                        //Deserialize json; Descerialização do json
                        List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonFile);

                        // Verify if the json is already populated; verifica se o json possui algum dado
                        if (bandas != null && bandas.Count > 0){
                            // Check the bands name already exist; verifi se o nome da banda existe
                            if (bandas.Where(x => x.nome.ToUpper() == nomeBanda.ToUpper()).Count() > 0){
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
                    // If the json only have one band; Se o json tem apenas uma banda
                    else{
                        
                        //Check if the jsonFile is empty
                        if (!String.IsNullOrEmpty(jsonFile)){
                            
                            Banda banda = JsonConvert.DeserializeObject<Banda>(jsonFile);

                            if (banda.nome.ToUpper() == nomeBanda.ToUpper()){
                                return true;
                            }
                            else{
                                return false;
                            }
                        }
                        else{
                            return false;
                        }
                    }
                    
                }
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
                return false;
            }
            
        }

    }
}