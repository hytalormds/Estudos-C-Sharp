class Program
{
    public static void Main()
    {
        int n = InputNumber();
        Dobro(n);
    }

    public static int InputNumber()
    {
        Console.WriteLine("Digite um número: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    public static void Dobro(int n)
    {
        Console.WriteLine($"{n*2}");
    }
}