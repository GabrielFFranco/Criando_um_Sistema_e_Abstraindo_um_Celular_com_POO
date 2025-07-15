namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _IMEI = imei;
            _memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public string Numero { get; set; }

        private string _modelo;
        public string Modelo
        {
            get => _modelo;
        }

        private string _IMEI;
        public string IMEI
        {
            get => _IMEI;
        }

        private int _memoria;
        public int Memoria
        {
            get => _memoria;
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