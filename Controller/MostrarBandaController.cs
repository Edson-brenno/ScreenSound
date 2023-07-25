using System;
using System.IO;
using System.Linq;
using ScreenSound.Model;
using Newtonsoft;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace ScreenSound.Controller{
    public class MostrarBandaController{
        
        private List<Banda> bandas;
        public MostrarBandaController(){

            string jsonFile = File.ReadAllText("bandas.json");

            this.bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonFile);
        }
        public void Mostrar(){

            int numero = 1;
            this.bandas.ForEach(banda => {
                System.Console.WriteLine($"{numero} ---- {banda.nome}"); 
                numero++;
                    
            });
            
        } 
    }
}