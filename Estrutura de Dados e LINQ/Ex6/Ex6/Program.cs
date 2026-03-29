using System.Collections.Generic;
using System.Linq;
class Program
{
    public static void Main()
    {
        List<string> products = new List<string>();
        InputProducts(products);
        SearchProducts(products);
    }
    public static void InputProducts(List<string> products)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string product = Console.ReadLine().ToUpper();
            if (product == "SAIR")
            {
                break;
            }
            products.Add(product);
        }
    }
    public static void SearchProducts(List<string> products)
    {
        Console.WriteLine("Digite o nome do produto para pesquisa: ");
        string search = Console.ReadLine().ToUpper();

        string research = products.Find(p => p.Equals(search, StringComparison.OrdinalIgnoreCase));

        if (research != null)
        {
            Console.WriteLine("Produto encontrado: " + research);
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}