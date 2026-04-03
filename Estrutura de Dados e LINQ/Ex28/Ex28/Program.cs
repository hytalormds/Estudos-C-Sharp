using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();

        InputProdutos(produtos);
        BuscaPorNome(produtos);
    }
    public static void InputProdutos(Dictionary<int, Produto> produtos)
    {
        while (true)
        {
            Console.WriteLine("Digite o ID para ser a chave: ");
            int id = int.Parse(Console.ReadLine());

            if (id == 0)
            {
                break;
            }

            if (produtos.ContainsKey(id))
            {
                Console.WriteLine("Produto já existe. Digite outro ID.");
                continue;
            }

            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto:");
            decimal preco = decimal.Parse(Console.ReadLine());

            Produto produto = new Produto
            {
                Id = id,
                Nome = nome,
                Quantidade = quantidade,
                Preco = preco
            };

            produtos.Add(id, produto);
        }
    }

    public static void BuscaPorNome(Dictionary<int, Produto> produtos)
    {
       Console.WriteLine("Digite o nome do produto para busca:");
       string nomeBusca = Console.ReadLine().ToUpper();

        var busca = produtos.Values.Where(p => p.Nome == nomeBusca);

        foreach (var produto in busca)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }
}