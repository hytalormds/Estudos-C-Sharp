using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int n = int.Parse(Console.ReadLine());

        int maior = n, menor = n, soma = n;

        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine("Digite o próximo valor: ");
            n = int.Parse(Console.ReadLine());

            if (n > maior)
            {
                maior = n;
            }
            if (n < menor)
            {
                menor = n;
            }
            soma += n;
        }

        Console.WriteLine("Maior: " + maior);
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine($"A média dos valores: {soma / 10.0}");
    }
}
