using System;
using System.IO;
using System.Linq;
using ScreenSound.Model;
using Newtonsoft.Json;

namespace ScreenSound.Controller{
    public class MostrarBandaController{
        
        private string jsonFile = ""; 
        public MostrarBandaController(){

            this.jsonFile = File.ReadAllText("bandas.json");
        }
        public void Mostrar(){
            
            if (this.jsonFile.Length == 0){
                System.Console.WriteLine("Sem bandas Cadastradas");
            }
            else if (!this.jsonFile.StartsWith('[')){
                Banda banda = JsonConvert.DeserializeObject<Banda>(this.jsonFile);

                System.Console.WriteLine($"1 --------------- {banda.nome}");
            }
            else {
                List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(this.jsonFile);

                int indice = 1;

                bandas.ForEach(banda => {
                    System.Console.WriteLine($"{indice} --------------- {banda.nome}");
                    indice++;
                });
            
            }
            
        } 
    }
}