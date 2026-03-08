class Program
{
    public static void Main()
    {
        string frase = InputVogals();
        SumVogals(frase);
    }
    public static string InputVogals()
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine().ToUpper();

        return frase;
    }

    public static void SumVogals(string frase)
    {
        char[] vogals = { 'A', 'E', 'I', 'O', 'U' };
        int soma = 0;

        foreach (char letra in frase)
        {
            if(Array.Exists(vogals, v => v == letra))
            {
                soma++;
            }
        }
        Console.WriteLine($"A quantidade de vogais na frase \"{frase}\" é {soma}");
    }
}