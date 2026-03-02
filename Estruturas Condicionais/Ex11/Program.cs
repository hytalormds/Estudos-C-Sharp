class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Número Negativo");
        }
        else
        {
            Console.WriteLine("Número Positivo");
        }
    }
}