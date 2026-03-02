class Program
{
    public static void Main()
    {
        int maior = 0;

        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        int menor = n;

        while (n > 0)
        {
            if (n > maior)
            {
                maior = n;
            }
            if (n < menor)
            {
                menor = n;
            }
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Maior: " + maior);
        Console.WriteLine("Menor: " + menor);
    }
}