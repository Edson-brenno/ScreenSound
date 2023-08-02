namespace ScreenSound.Model{
    public class Banda {
        //Nome banda
        public string nome = "";

        //Data registro
        public DateTime dtRegistro = DateTime.Now;

        //Nota
        public double[] notas = {};

        //To String:
        public override string ToString(){
            return $"{this.nome}";
        }
    }
}