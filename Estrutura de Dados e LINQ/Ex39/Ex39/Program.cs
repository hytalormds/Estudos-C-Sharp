using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        List<Produto> produtos = new List<Produto>();
        HashSet<string> nomes = new HashSet<string>();

        InputDados(produtos, nomes);
        ExibirDados(produtos);
    }
    public static void InputDados(List<Produto> produtos, HashSet<string> nomes)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string produtoNome = Console.ReadLine().ToUpper();

            if (produtoNome == "SAIR")
            {
                break;
            }

            if (nomes.Contains(produtoNome))
            {
                Console.WriteLine("Produto já cadastrado. Digite outro nome.");
                continue;
            }

            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Produto produto = new Produto
            {
                Nome = produtoNome,
                Quantidade = quantidade,
                Preco = preco
            };

            produtos.Add(produto);
            nomes.Add(produtoNome);
        }
    }
    public static void ExibirDados(List<Produto> produtos)
    {
        Console.WriteLine("Produtos cadastrados: ");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }
}