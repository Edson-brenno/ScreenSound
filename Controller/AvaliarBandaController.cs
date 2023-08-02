using Newtonsoft.Json;
using ScreenSound.Model;

namespace ScreenSound.Controller{
    public class AvaliarBandaController{

        public static void AvaliarBanda(int indiceBanda){

            string jsonFile = "";

            using( StreamReader r = new StreamReader("bandas.json")){
                jsonFile = r.ReadToEnd(); // Read the json; Lê o json
            }
            
            List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonFile); //Deserialize the jsonFile; Descerializa o arquivo json
            Banda[] bandasArray  = bandas.ToArray(); // Transform the list into an array; transforma a lista de bandas em array

            // Adicione a nova nota ao array de notas da banda selecionada
            List<double> notasList = bandasArray[indiceBanda - 1].notas.ToList();
            notasList.Add(1.1);
            bandasArray[indiceBanda - 1].notas = notasList.ToArray();

            List<Banda> bandasAtualizada = bandasArray.ToList();

            string jsonAtualizado = JsonConvert.SerializeObject(bandasAtualizada);

            //Write the updated json; Escreve o novo json
            using (StreamWriter sw = new StreamWriter("bandas.json")){
                sw.Write(jsonAtualizado);
            }
            

        }
    }
}