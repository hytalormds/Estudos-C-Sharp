class Program
{
    public static void Main()
    {
        int maior, menor;

        Console.WriteLine("Digite o número (0 para sair): ");
        int n = int.Parse(Console.ReadLine());

        maior = n;
        menor = n;

        while (n != 0)
        {
            if (n > maior)
            {
                maior = n;
            }

            if (n < menor)
            {
                menor = n;
            }

            Console.WriteLine("Digite o número (0 para sair): ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Maior número digitado: " + maior);
        Console.WriteLine("Menor número digitado: " + menor);
    }
}
