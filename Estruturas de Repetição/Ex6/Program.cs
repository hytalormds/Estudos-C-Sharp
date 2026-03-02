class Program
{
    public static void Main()
    {
        int somaPar = 0, somaImpar = 0;

        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            if(n % 2 == 0)
            {
                somaPar += n;
            }
            else
            {
                somaImpar += n;
            }
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Soma Par: " + somaPar);
        Console.WriteLine("Soma Ímpar: " + somaImpar);
    }
}