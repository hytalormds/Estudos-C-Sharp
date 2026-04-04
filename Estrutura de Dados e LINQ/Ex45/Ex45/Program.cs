using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        HashSet<string> produtos = new HashSet<string>();

        while (true)
        {
            Console.WriteLine("Escolha as opções: ");
            Console.WriteLine("1 - Cadastrar produtos");
            Console.WriteLine("2 - Exibir produtos");
            Console.WriteLine("3 - Remover produtos");
            Console.WriteLine("4 - Sair");

            Console.WriteLine("\n");

            Console.WriteLine("Digite a opção desejada: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    InputProducts(produtos);
                    break;
                case 2:
                    DisplayProducts(produtos);
                    break;
                case 3:
                    RemoveProducts(produtos);
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente");
                    break;
            }
        }
    }
    public static void InputProducts(HashSet<string> produtos)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(nome))
            {
                break;
            }

            produtos.Add(nome);
        }
    }
    public static void DisplayProducts(HashSet<string> produtos)
    {
        foreach (var produt in produtos)
        {
            Console.WriteLine(produt);
        }
    }
    public static void RemoveProducts(HashSet<string> produtos)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto para remover: ");
            string nomeRemover = Console.ReadLine().ToUpper();

            if (produtos.Contains(nomeRemover))
            {
                produtos.Remove(nomeRemover);
            }
            if (string.IsNullOrEmpty(nomeRemover))
            {
                break;
            }
        }
    }
}