class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        HashSet<Produto> produtos = new HashSet<Produto>();

        InputDados(produtos);
        ExibirDados(produtos);
    }
    public static void InputDados(HashSet<Produto> produtos)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine().ToUpper();

            if (nome == "SAIR")
            {
                break;
            }

            Console.WriteLine("Digite o código de barras: ");
            string codigoBarras = Console.ReadLine().ToUpper();

            Produto produto = new Produto
            {
                Nome = nome,
                CodigoBarras = codigoBarras
            };

            if (!produtos.Add(produto))
            {
                Console.WriteLine("Produto duplicado!");
            }
        }
    }
    public static void ExibirDados(HashSet<Produto> produtos)
    {
        Console.WriteLine("Produtos cadastrados: ");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Código de Barras: {produto.CodigoBarras}");
        }
    }
}