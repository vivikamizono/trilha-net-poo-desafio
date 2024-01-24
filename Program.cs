using DesafioPOO.Models;
class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo A", imei: "10101", memoria: 120 );
        Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo B", imei: "01010", memoria: 210 );

        Console.WriteLine("Smartphone Nokia: ");
        Console.WriteLine("Escolha sua opção: \n 1- Realizar Ligação. \n 2- Enviar Mensagem \n 3- Instalar Aplicativo \n 4- Desinstalar aplicativo.");

        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            RealizarLigacao();
            Console.WriteLine("Smartphone Iphone: ");
            iphone.ReceberLigacao();
        }

        else if (escolha == "2")
        {
            EnviarMensagem();
            Console.WriteLine("Smartphone Iphone: ");
            iphone.ReceberMenssagem();
        }

        else if (escolha == "3")
        {   
        Console.WriteLine("Escolha seu smartphone: \n 1- Nokia \n 2- Iphone");
        string escolhaSmartphone = Console.ReadLine();

        Smartphone smartphone;

        if (escolhaSmartphone == "1")
        {
            smartphone = new Nokia(numero: "123456", modelo: "Modelo A", imei: "01011", memoria: 256);
             InstalarAplicativo();
            nokia.InstalarAplicativo("Instagram no modelo Nokia");
        }


        else if (escolhaSmartphone == "2")
        {
            smartphone = new Iphone(numero: "654321", modelo: "Modelo B", imei: "01010", memoria: 210);
             InstalarAplicativo();
            iphone.InstalarAplicativo("WhatsApp no modelo Iphone");
        }


        else
        {
            Console.WriteLine("Opção inválida. Encerrando programa.");
            return;
        }
        
        }
        else if (escolha == "4")
        {
            Console.WriteLine("Escolha seu smartphone: \n 1- Nokia \n 2- Iphone");
            string escolhaSmartphone = Console.ReadLine();

        Smartphone smartphone;

        if (escolhaSmartphone == "1")
        {
            smartphone = new Nokia(numero: "123456", modelo: "Modelo A", imei: "01011", memoria: 256);
            DesinstalarAplicativo();
            nokia.DesinstalarAplicativo("Instagram no modelo Nokia");
        }


        else if (escolhaSmartphone == "2")
        {
            smartphone = new Iphone(numero: "654321", modelo: "Modelo B", imei: "01010", memoria: 210);
            DesinstalarAplicativo();
            iphone.DesinstalarAplicativo("WhatsApp no modelo Iphone");
        }


        else
        {
            Console.WriteLine("Opção inválida. Encerrando programa.");
            return;
        }
        
        }


        else
        {
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
        }
    }

    static void RealizarLigacao()
    {
        Console.WriteLine("Modelo Nokia realizando ligação...");
    }

    static void EnviarMensagem()
    {
        Console.WriteLine("Enviando mensagem...");
    }

    static void InstalarAplicativo()
    {
        Console.WriteLine("Instalando aplicativo...");
    }

    static void DesinstalarAplicativo()
    {
        Console.WriteLine("Desinstalando aplicativo...");
    }
}
