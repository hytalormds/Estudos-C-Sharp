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
    public static void InputProducts(List<string> Products)
    {
        while (true)
        {
            Console.WriteLine("Digite os produtos: ");
            string product = Console.ReadLine().ToUpper();

            if (product == "SAIR") {
                break;
            }
            Products.Add(product);
        }
    }
    public static void SearchProducts(List<string> Products)
    {
        Console.WriteLine("Digite o produto a ser pesquisado: ");
        string search = Console.ReadLine().ToUpper();
        search = Products.FirstOrDefault(p => p == search);
        Console.WriteLine(search);
    }
}