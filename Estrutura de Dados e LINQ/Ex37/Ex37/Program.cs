class Program
{
    public static void Main()
    {
        HashSet<string> produtos = new HashSet<string>();
        InputNames(produtos);
        ExibirNomes(produtos);
    }
    public static void InputNames(HashSet<string> produtos)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome: ");
            string produto = Console.ReadLine().ToUpper();

            if (produtos.Contains(produto))
            {
                Console.WriteLine("Nome já existe. Digite outro nome.");
                continue;
            }

            if (string.IsNullOrEmpty(produto))
            {
                break;
            }

            produtos.Add(produto);
        }
    }
    public static void ExibirNomes(HashSet<string> produtos)
    {
        Console.WriteLine("Nomes digitados:");
        foreach (string p in produtos)
        {
            Console.WriteLine(p);
        }
    }
}