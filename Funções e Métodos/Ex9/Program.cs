class Program
{
    public static void Main()
    {
        int n = InputNumber();
        Contador(n);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        return n;
    }

    public static void Contador(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}