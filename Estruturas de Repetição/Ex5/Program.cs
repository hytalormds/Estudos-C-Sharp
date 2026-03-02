class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("[TABUADA]");

        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {n} = {i*n}");
        }
    }
}