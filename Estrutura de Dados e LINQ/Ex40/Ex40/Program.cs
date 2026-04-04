using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        List<Produto> produtos = new List<Produto>();
        HashSet<string> codigosBarras = new HashSet<string>();

        InputProdutos(produtos, codigosBarras);
        ExibirProdutos(produtos);
    }
    public static void InputProdutos(List<Produto> produtos, HashSet<string> codigosBarras)
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
            string codigo = Console.ReadLine();

            if (codigosBarras.Contains(codigo))
            {
                Console.WriteLine("Código de barras já cadastrado. Tente novamente.");
                continue;
            }
            Produto produto = new Produto
            {
                Nome = nome,
                CodigoBarras = codigo
            };
            produtos.Add(produto);
            codigosBarras.Add(codigo);
        }
    }
    public static void ExibirProdutos(List<Produto> produtos)
    {
        Console.WriteLine("Produtos cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Código de Barras: {produto.CodigoBarras}");
        }
    }
}