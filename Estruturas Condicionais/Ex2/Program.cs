class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 0)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine($"{num * -1}");
        }
    }
}