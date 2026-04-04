class Program
{
    public static void Main()
    {
        HashSet<string> produto = new HashSet<string>();
        InputProducts(produto);
        ExibirProdutos(produto);
    }
    public static void InputProducts(HashSet<string> produtos)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string product = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(product))
            {
                break;
            }
            produtos.Add(product);
        }
    }
    public static void ExibirProdutos(HashSet<string> produtos)
    {
        Console.WriteLine("Produtos cadastrados: ");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }
}