class Program
{
    public static void Main()
    {
        HashSet<string> nomes = new HashSet<string>();
        InputString(nomes);
        ExibirNomes(nomes);
    }
    public static void InputString(HashSet<string> nomes)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(nome))
            {
                break;
            }

            nomes.Add(nome);
        }
    }
    public static void ExibirNomes(HashSet<string> nomes)
    {
        foreach (var n in nomes)
        {
            Console.WriteLine($"{n}");
        }
    }
}