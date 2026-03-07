class Program
{
    public static void Main()
    {
        int n1 = InputNumber();
        int n2 = InputNumber();
        MaiorNumero(n1, n2);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite um número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static void MaiorNumero(int n1, int n2)
    {
        if (n1 > n2)
        {
            Console.WriteLine($"{n1} e maior {n2}");
        }
        else
        {
            Console.WriteLine($"{n2} e maior {n1}");
        }
    }
}