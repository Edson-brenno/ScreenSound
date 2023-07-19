namespace ScreenSound.Configuracao{

    public class ConfiguracaoScreenSound{ //This class will be used for screenSound First configuration; Classe a ser usada caso o screensound não foi configurado

        
        public static bool JaFoiConfigurado(){ // Check if the application was already configured; Verifica se a aplicação já foi configurada
            if (File.Exists("bandas.json")){
                return true;
            }
            else {
                return false;
            }
        }

        public static void Configurar(){ //Do the configuration of the application; Faz a configuração da aplicação
            
            using (File.CreateText("bandas.json")){};

        }
    }
}