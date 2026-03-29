using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        List<int> num = new List<int>();
        int i = 0;

        while (i < 5) { 
            Console.WriteLine("Digite os valores: ");
            int n = int.Parse(Console.ReadLine());
            num.Add(n);
            i++;
        }
        Console.WriteLine("\n");
        Console.WriteLine("Números: ");
        foreach (var item in num)
        {
            Console.WriteLine(item);
        }
    }
}