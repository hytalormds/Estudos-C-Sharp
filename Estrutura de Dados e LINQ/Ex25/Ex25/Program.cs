using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Produto prod = new Produto();

        Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();

        InputProducts(produtos);
        ExibirProdutos(produtos);
    }
    public static void InputProducts(Dictionary<int, Produto> produtos)
    {
        while (true)
        {
            Console.WriteLine("Chave: ");
            int chave = int.Parse(Console.ReadLine()?.Trim());

            if (chave == 0)
            {
                break;
            }

            if (produtos.ContainsKey(chave))
            {
                Console.WriteLine("Chave já existe. Tente novamente.");
                continue;
            }

            Console.WriteLine("Valor: ");
            string valor = Console.ReadLine();

            Console.WriteLine($"Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto
            {
                Chave = chave,
                Nome = valor,
                Quantidade = quantidade
            };

            produtos.Add(chave, produto);
        }
    }
    public static void ExibirProdutos(Dictionary<int, Produto> produtos)
    {
        foreach (var item in produtos)
        {
            Console.WriteLine($"Chave: {item.Key} - Nome: {item.Value.Nome} - Quantidade: {item.Value.Quantidade}");
        }
    }
}