using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();

        InputProdutos(produtos);
        Quantidade0(produtos);
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
            string nome = Console.ReadLine();

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

    public static void Quantidade0(Dictionary<int, Produto> produtos)
    {
        var removerProdutos = produtos
            .Where(p => p.Value.Quantidade == 0)
            .Select(p => p.Key)
            .ToList();

        foreach (var chave in removerProdutos)
        {
            produtos.Remove(chave);
        }

        foreach (var produto in produtos.Values)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }
}