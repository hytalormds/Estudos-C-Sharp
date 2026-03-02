class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor N1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor N2: ");
        int n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine($"{n1} e maior que {n2}");
        }
        else if (n1 < n2)
        {
            Console.WriteLine($"{n2} e maior que {n1}");
        }else if (n1 == n2)
        {
            Console.WriteLine("Os números são iguais");
        }
    }
}