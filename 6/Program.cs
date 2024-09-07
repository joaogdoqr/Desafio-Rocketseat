namespace _6;

class Program
{
    static void Main(string[] args)
    {
        var agora = DateTime.UtcNow;
        
        Console.WriteLine($"Formato completo: {agora:dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm:ss}");
        Console.WriteLine($"Formato ddMMyyyy: {agora:dd, MM, yyyy}");
        Console.WriteLine($"Apenas hora: {agora:HH, mm, ss}");
        Console.WriteLine($"Data com mês por extenso: {agora:dd 'de' MMMM 'de' yyyy}");  
        
        
    }
}

