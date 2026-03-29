using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int i = 0;
        Produto produto = new Produto();

        while (i < 3)
        {
            Console.WriteLine("Digite os nomes: ");
            produto.AdicionarProduto(Console.ReadLine());
            i++;
        }
        Console.WriteLine("\n");
        Console.WriteLine("Produtos: ");
        produto.ExibirProdutos();
    }
}