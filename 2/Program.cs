namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        var nome = Console.ReadLine();
        
        Console.Write("Digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();
        
        Console.Write($"Nome completo: {nome} {sobrenome}");
    }
}