class Program
{
    public static void Main()
    {
        int[] numbers = InputNumbers();
        BiggerNumber(numbers);
    }

    public static int[] InputNumbers()
    {
        Console.WriteLine("Digite a quantidade de números: ");
        int qtdNumbers = int.Parse(Console.ReadLine());

        int[] numbers = new int[qtdNumbers];

        for (int i = 0; i < qtdNumbers; i++)
        {
            Console.WriteLine($"Digite os números: {i + 1}");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }

    public static void BiggerNumber(int[] numbers)
    {
        int maior = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maior)
            {
                maior = numbers[i];
            }
        }
        Console.WriteLine($"O maior número é: {maior}");
    }
}