using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<int, string> produtos = new Dictionary<int, string>();

        InputProducts(produtos);
        ContemChave(produtos);
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

            if (chave == 0)
            {
                break;
            }

            Console.WriteLine("Valor: ");
            string valor = Console.ReadLine();

            produtos.Add(chave, valor);
        }
    }
    public static void ContemChave(Dictionary<int, string> produtos)
    {
        Console.WriteLine("Digite a chave para verificar se existe: ");
        int id = int.Parse((Console.ReadLine()));

        if (produtos.ContainsKey(id))
        {
            Console.WriteLine($"ID: {id} | Valor: {produtos[id]}");
        }
        else
        {
            Console.WriteLine($"A chave {id} não existe no dicionário.");
        }
    }
}