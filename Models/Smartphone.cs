namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero {get; set; }
        private string Modelo {get; set; }
        private string Imei {get; set; }
        private int Memoria {get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Digite o numero: ");
            Numero = Console.ReadLine();

            Console.WriteLine("Ligando...");
        }

        
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Menssagem()
        {
            Console.WriteLine("Digite o numero: ");
            Numero = Console.ReadLine();

            Console.WriteLine("Enviando menssagem de texto...");
        }

         public void ReceberMenssagem()
        {
            Console.WriteLine("Recebendo Menssagem de texto!! ");
            Numero = Console.ReadLine();

            Console.WriteLine("Enviando menssagem de texto...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void DesinstalarAplicativo(string nomeApp);

    }
}
