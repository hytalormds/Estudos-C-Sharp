class Program
{
    public static void Main()
    {
        HashSet<string> nomes = new HashSet<string>();
        InputNames(nomes);
        ExibirNomes(nomes);
    }
    public static void InputNames(HashSet<string> nomes)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine().ToUpper();

            if (nomes.Contains(nome))
            {
                Console.WriteLine("Nome já existe. Digite outro nome.");
                continue;
            }

            if (string.IsNullOrEmpty(nome))
            {
                break;
            }

            nomes.Add(nome);
        }
    }
    public static void ExibirNomes(HashSet<string> nomes)
    {
        Console.WriteLine("Nomes digitados:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}