class Program
{
    public static void Main()
    {
        int n = InputNumber();
        Verifica(n);

        Console.WriteLine($"O número {n} é {Verifica(n)}");
    }

    public static int InputNumber()
    {
        Console.WriteLine("Digite um número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static bool Verifica(int n)
    {
        if (n > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}