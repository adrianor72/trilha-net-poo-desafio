namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
{
    public override void InstalarAplicativo(string nome)
    {
         // TODO: Sobrescrever o método "InstalarAplicativo"
        Console.WriteLine($"Instalando o aplicativo {nome} no iPhone.");
    }
}
}