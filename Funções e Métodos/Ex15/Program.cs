class Program
{
    public static void Main()
    {
        int[] numbers = InputNumbers();
        SumNumbers(numbers);
    }
    public static int[] InputNumbers()
    {
        Console.WriteLine("Digite a quantidade de números do array: ");
        int qtdNumbers = int.Parse(Console.ReadLine());

        int[] numbers = new int[qtdNumbers];

        for (int i = 0; i < qtdNumbers; i++)
        {
            Console.WriteLine($"Digite o número: {i+1}");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }

    public static void SumNumbers(int[] numbers)
    {
        int soma = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            soma += numbers[i];
        }
        Console.WriteLine($"A soma dos números: {soma}");
    }
}