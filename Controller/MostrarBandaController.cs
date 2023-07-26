using System;
using System.IO;
using System.Linq;
using ScreenSound.Model;
using Newtonsoft.Json;

namespace ScreenSound.Controller{
    public class MostrarBandaController{ // Controller to show the bands; Controller para mostrar as bandas
        
        private string jsonFile = ""; // Json File; Arquivo Json
        public MostrarBandaController(){ //Constructor; Construtor

            this.jsonFile = File.ReadAllText("bandas.json"); // Read the json; Lê o json
        }

        public int TotalRegistros(){ // Return the total of bands wich were registered; Retorna o total de bandas cadastradas
            if (this.jsonFile.Length == 0){ // If the json has no band; Caso o json não tenha bandas
                return 0;
            }
            else if (!this.jsonFile.StartsWith('[')){ // Case the json only has 1 band; caso o json tenha apenas uma banda
                return 1;
            }
            else { // Return the total of bands; Retorna total bandas
                List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(this.jsonFile);

                return bandas.Count;    
            }
        }
        public void Mostrar(int pagina){ // Will show in the maximum 3 bands per page; Mostra as bandas de acordo a página mostrando no máximo 3 registror por pagina
            
            if (this.jsonFile.Length == 0){ // If the json do not have any bands; Caso o json não tenha bandas
                System.Console.WriteLine("Sem bandas Cadastradas");
            }
            else if (!this.jsonFile.StartsWith('[')){ // If the json only has one band; Caso o json tenha apenas uma banda
                Banda banda = JsonConvert.DeserializeObject<Banda>(this.jsonFile);

                System.Console.WriteLine($"1 --------------- {banda.nome}");
            }
            else { // Case the json has more than 1 band; caso o json tenha mais de uma banda

                List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(this.jsonFile); //Deserialize the jsonFile; Descerializa o arquivo json
                Banda[] bandasArray  = bandas.ToArray(); // Transform the list into an array; transforma a lista de bandas em array

                int indice = 1;

                if (pagina == 1 && bandas.Count <= 3){
                    for(int i = 0; i < bandas.Count; i++){
                        System.Console.WriteLine($"{indice} ----------------- {bandasArray[i]}");
                        indice++;
                    }
                }
                else if (pagina == 1 && bandas.Count > 3){
                    for(int i = 0; i < pagina + 2; i++){
                        System.Console.WriteLine($"{indice} ----------------- {bandasArray[i]}");
                        indice++;
                    }
                }
                else if (pagina > 1 && bandas.Count < 3 * pagina){
                    for(int i = (3 *pagina) - 3; i < bandas.Count; i++){
                        System.Console.WriteLine($"{indice} ----------------- {bandasArray[i]}");
                        indice++;
                    }
                }
                else{
                    for(int i = (3 *pagina) - 3; i <= (3 * pagina) - 1; i++){
                        System.Console.WriteLine($"{indice} ----------------- {bandasArray[i]}");
                        indice++;
                    }
                }
                
            
            }
            
        } 
    }
}