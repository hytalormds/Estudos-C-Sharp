class Program
{
    public static void Main()
    {
        string palavra = InputPalavra();
        Palindromo(palavra);
    }
    public static string InputPalavra()
    {
        Console.WriteLine("Digite a palavra: ");
        string palavra = Console.ReadLine().ToUpper();

        return palavra;
    }
    public static void Palindromo(string palavra)
    {
        string palavraInvertida = "";

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            palavraInvertida += palavra[i];
        }
        if(palavra.ToLower() == palavraInvertida.ToLower())
        {
            Console.WriteLine("Palindromo");
        }
        else
        {
            Console.WriteLine("Não É Palíndromo");
        }
    }
}