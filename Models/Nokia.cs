namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }

        //Implementação para o metodo InstalarAplicativo, q vai herdar de uma abstrata
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}");
            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }

        public override void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando o aplicativo {nomeApp}");
            Console.WriteLine($"{nomeApp} desinstalado com sucesso!");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
