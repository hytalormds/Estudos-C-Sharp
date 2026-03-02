class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número: ");
        int n2 = int.Parse(Console.ReadLine());

        if(n1 > n2)
        {
            Console.WriteLine($"{n1 - n2}");
        }
        else
        {
            Console.WriteLine($"{n2-n1}");
        }
    }
}