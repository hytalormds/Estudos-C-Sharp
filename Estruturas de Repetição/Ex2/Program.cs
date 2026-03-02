class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());

        int i=1, fat=1;

        while(i <= n)
        {
            fat *= i;
            i++;
        }
        Console.WriteLine($"O fatorial de {n} é {fat}");
    }
}