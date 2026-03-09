using System.Linq;

class Program
{
    public static void Main()
    {
        string palavra = InputString();
        InverterString(palavra);
    }
    public static string InputString()
    {
        Console.WriteLine("Digite a string: ");
        string palavra = Console.ReadLine().ToUpper();

        return palavra;
    }
    public static void InverterString(string palavra)
    {
       string palavraInvertida = new string(palavra.Reverse().ToArray());

       Console.WriteLine($"A palavra {palavra} invertida é {palavraInvertida}");
    }
}