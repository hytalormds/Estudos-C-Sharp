using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<int, string> produtos = new Dictionary<int, string>();

        InputProducts(produtos);
        ExibirProdutos(produtos);
    }
    public static void InputProducts(Dictionary<int, string> produtos)
    {
        while (true)
        {
            Console.WriteLine("Chave: ");
            int chave = int.Parse(Console.ReadLine()?.Trim());

            if (chave == null)
            {
                Console.WriteLine("A chave não pode ser vazia");
                continue;
            }

            if(chave == 0)
            {
                break;
            }

            Console.WriteLine("Valor: ");
            string valor = Console.ReadLine();

            produtos.Add(chave, valor);
        }
    }
    public static void ExibirProdutos(Dictionary<int, string> produtos)
    {
        Console.WriteLine("Produtos Cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Chave: {produto.Key} | Valor: {produto.Value}");
        }
    } 
}