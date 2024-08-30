namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        private string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor vazio
        public Smartphone()
        {
            Numero = Numero; 
            Modelo = Modelo;
            IMEI = "000000000000000"; 
            Memoria = Memoria;
        }

        public Smartphone(string numero,string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei; // IMEI fictício
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}