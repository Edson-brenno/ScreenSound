using Newtonsoft.Json;
using ScreenSound.Model;

namespace ScreenSound.Controller{
    public class MediaBandaController{

        public static string MediaBanda(int indiceBanda){

            string jsonFile = "";

            using( StreamReader r = new StreamReader("bandas.json")){
                jsonFile = r.ReadToEnd(); // Read the json; Lê o json
            }
            
            List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonFile); //Deserialize the jsonFile; Descerializa o arquivo json
            Banda[] bandasArray  = bandas.ToArray(); // Transform the list into an array; transforma a lista de bandas em array

            // Adicione a nova nota ao array de notas da banda selecionada
            List<double> notasList = bandasArray[indiceBanda - 1].notas.ToList();

            double media = notasList.Count() > 0 ? notasList.Average() : 0;
            
            return "================================================" + 
            $"\nA media da banda {bandasArray[indiceBanda - 1].ToString()} é {media}";
            
        }
    }
}