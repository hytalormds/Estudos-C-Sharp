class Program
{
    public static void Main()
    {
        int n = NumberInput();
        Tabuada(n);
    }
    public static int NumberInput()
    {
        Console.WriteLine("Digite um número: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    public static void Tabuada(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}x{n} = {i*n}");
        }
    }
}