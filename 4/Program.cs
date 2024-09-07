namespace _4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma frase: ");
        var frase = Console.ReadLine();
        var caracteres = 0;

        for (var i = 0; i < frase!.Length; i++)
        {
            if (char.IsWhiteSpace(frase[i]))
            {
                continue;
            }

            caracteres++;
        }
        
        Console.WriteLine($"A frase tem {caracteres} caracteres");
    }
}