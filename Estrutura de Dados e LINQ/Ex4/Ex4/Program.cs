class Program
{
    public static void Main()
    {
        List<string> produtos = new List<string>();
        int i = 0;

        while (i < 5)
        {
            Console.WriteLine("Digite o produto: ");
            string prod = Console.ReadLine();
            produtos.Add(prod);
            i++;
        }
        produtos.RemoveAt(2);
        foreach (string prod in produtos)
        {
            Console.WriteLine(prod);
        }
    }
}