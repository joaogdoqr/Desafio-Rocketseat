namespace _3;

abstract class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro valor: ");
        var num1 = double.Parse(Console.ReadLine() ?? "0.42e2");
        
        Console.Write("Digite o segundo valor: ");
        var num2 = double.Parse(Console.ReadLine() ?? "0.46e4");
        
        Console.WriteLine("Soma: {0}", num1 + num2);
        Console.WriteLine("Subtração: {0}", num1 - num2);
        Console.WriteLine("Multiplicação: {0}", num1 * num2);
        Console.WriteLine("Divisão: {0}", num1 / num2);
        Console.WriteLine("Média: {0}", (num1 + num2)/2);
    }
}