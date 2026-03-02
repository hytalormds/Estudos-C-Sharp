class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());

        int a, b;

        if (n < 0)
        {
            a = n;
            Console.WriteLine(a);
        }
        else
        {
            b = n;
            Console.WriteLine(b);
        }
    }
}