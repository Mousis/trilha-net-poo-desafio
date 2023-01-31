using DesafioPOO.Models;

    class Program{
        static void Main(String[] args)
        {
            Console.WriteLine("Nókia");
            Nokia nokia = new Nokia("NokiaPrime", "ModeloOne", "Nokia@", 128);
            nokia.Ligar();
            nokia.ReceberLigacao();

            Console.WriteLine("Iphone");
            Iphone iphone = new Iphone("Iphone", "iphone 15", "Iphone@", 64);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
             
            

        }
    }