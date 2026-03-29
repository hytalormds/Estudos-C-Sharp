using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<string> nomes = new List<string>();

        int i = 0;

        while (i < 5)
        {
            Console.WriteLine("Digite o nome: ");
            string n = Console.ReadLine().ToUpper();
            nomes.Add(n);
            i++;
        }
        Console.WriteLine("Digite o nome a ser removido:");
        string remover = Console.ReadLine().ToUpper();
        nomes.Remove(remover);

        Console.WriteLine("\n");

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        Console.WriteLine($"Quantidade de nomes: {nomes.Count}");
    }
}