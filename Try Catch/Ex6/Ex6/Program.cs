class Program
{
    public static void Main()
    {
        (int number1, int number2, int number3) dados = InputDados();
        CalculaMedia(dados.number1, dados.number2, dados.number3);
    }
    public static (int number1, int number2, int number3) InputDados()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite o primeiro número:");
                int number1 = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite o segundo número:");
                int number2 = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite o terceiro número:");
                int number3 = int.Parse(Console.ReadLine()!);
                return (number1, number2, number3);

            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}

public static void CalculaMedia(int number1, int number2, int number3)
    {
        double media = (number1 + number2 + number3) / 3.0;
        Console.WriteLine($"A média dos números é: {media}");
    }
}