namespace _5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a placa: ");
        var placa = Console.ReadLine();

        if (placa == null || placa!.Length != 7)
        {
            Console.WriteLine("Falso");
            return;
        }

        for (var i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
            {
                Console.WriteLine("Falso");
                return;   
            }
        }
    
        for (var i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
            {
                Console.WriteLine("Falso");
                return;    
            }
        }
        
        Console.WriteLine("Verdadeiro");
    }
}