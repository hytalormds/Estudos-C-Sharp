using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Produto prod = new Produto();

        Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();

        InputProducts(produtos);
        NovaQuantidade(produtos);
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
    public static void NovaQuantidade(Dictionary<int, Produto> produtos)
    {
        Console.WriteLine("Digite o ID da chave: ");
        int id = int.Parse(Console.ReadLine());

        if (produtos.ContainsKey(id))
        {
            Produto produto = produtos[id];
            Console.WriteLine("Digite a nova quantidade: ");
            int novaQuantidade = int.Parse(Console.ReadLine());
            produto.Quantidade = novaQuantidade;

            foreach (var item in produtos)
            {
                Console.WriteLine($"Chave: {item.Value.Chave}, Nome: {item.Value.Nome}, Quantidade: {item.Value.Quantidade}");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}