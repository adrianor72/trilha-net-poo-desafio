using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia();
        nokia.Numero = "123456789";
        nokia.Memoria = 64;
        nokia.Ligar();
        //nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("Smartphone IPhone:");
        Iphone iphone = new Iphone();
        iphone.Numero = "987654321";
        iphone.Memoria = 128;
        //iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");