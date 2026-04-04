using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        List<Produto> produtos = new List<Produto>();
 
        InputDados(produtos);
        LimparDuplicados(produtos);
    }
    public static void InputDados(List<Produto> produtos)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine().ToUpper();

            if (nome == "SAIR") {
                break;
            }

            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            produtos.Add(new Produto
            {
                Nome = nome,
                Quantidade = quantidade,
                Preco = preco
            });
        }
    }
    public static void LimparDuplicados(List<Produto> produtos)
    {
        var nomesUnicos = new HashSet<string>(
            produtos.Select(p => p.Nome)
        );

        Console.WriteLine("Produtos únicos:");
        foreach (var nome in nomesUnicos)
        {
            Console.WriteLine(nome);
        }
    }
}