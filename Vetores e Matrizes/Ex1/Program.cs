class Program
{
    public static void Main()
    {
        int[] numbers = InputNumbers();
        InverterVetor(numbers);
    }
    public static int[] InputNumbers()
    {
        Console.WriteLine("Digite a quantidade de números: ");
        int qtd = int.Parse(Console.ReadLine());

        int[] numbers = new int[qtd];

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Digite o número na posição {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }

    public static void InverterVetor(int[] numbers)
    {
        Array.Reverse(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}
