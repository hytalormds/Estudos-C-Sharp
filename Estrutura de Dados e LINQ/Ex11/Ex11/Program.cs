using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        List<Produto> products = new List<Produto>();

        InputProduct(products);
        QtdEstoque(products);
    }

    public static void InputProduct(List<Produto> products)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            products.Add(new Produto
            {
                Nome = nome,
                Quantidade = quantidade
            });

            Console.WriteLine("Deseja Continuar? S/N");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "N")
            {
                break;
            }
        }
    }

    public static void QtdEstoque(List<Produto> products)
    {
        var resultado = products
            .Where(p => p.Quantidade > 10)
            .ToList();

        foreach (var product in resultado)
        {
            Console.WriteLine($"Produto: {product.Nome}, Quantidade: {product.Quantidade}");
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
    }
}