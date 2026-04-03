using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar produtos");
            Console.WriteLine("2 - Buscar por ID");
            Console.WriteLine("3 - Atualizar estoque");
            Console.WriteLine("4 - Remover produto");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("\n");

            Console.WriteLine("Digite a opção desejada: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    AdicionarProdutos(produtos);
                    break;
                case 2:
                    BuscarId(produtos);
                    break;
                case 3:
                    AtualizarEstoque(produtos);
                    break;
                case 4:
                    RemoverProduto(produtos);
                    break;
                case 5:
                    Sair(produtos);
                    return;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    break;
            }

        }
    }

    public static void AdicionarProdutos(Dictionary<int, Produto> produtos)
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
                Console.WriteLine("ID existente. Digite outro ID");
                continue;
            }

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto: ");
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

    public static void BuscarId(Dictionary<int, Produto> produtos)
    {
        Console.WriteLine("Digite o id do produto a ser pesquisado: ");
        int chave = int.Parse(Console.ReadLine());

        if (produtos.ContainsKey(chave))
        {
            Produto produto = produtos[chave];
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");

        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    public static void AtualizarEstoque(Dictionary<int, Produto> produtos)
    {
        Console.WriteLine("Digite o id do produto a ser atualizado: ");
        int chave = int.Parse(Console.ReadLine());

        if (produtos.TryGetValue(chave, out Produto produto))
        {
            Console.WriteLine($"Produto encontrado: ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");

            Console.WriteLine("Digite a nova quantidade do produto: ");
            int novaQuantidade = int.Parse(Console.ReadLine());

            produtos[chave].Quantidade = novaQuantidade;
        }
    }

    public static void RemoverProduto(Dictionary<int, Produto> produtos)
    {
        Console.WriteLine("Digite o id do produto a ser removido: ");
        int chave = int.Parse(Console.ReadLine());

        if (produtos.TryGetValue(chave, out Produto produto))
        {
            Console.WriteLine($"Produto encontrado: ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");

            produtos.Remove(chave);
        }
    }

    public static void Sair(Dictionary<int, Produto> produtos)
    {
        foreach (var produto in produtos.Values)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }
}