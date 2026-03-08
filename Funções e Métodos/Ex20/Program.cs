class Program
{
    public static void Main()
    {
        int[] numbers = InputNumbers();
        Ordenar(numbers);
    }
    public static int[] InputNumbers()
    {
        Console.WriteLine("Digite a quantidade de números: ");
        int qtd = int.Parse(Console.ReadLine());

        int[] numbers = new int[qtd];

        for(int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Digite os números: {i+1}");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }

    public static void Ordenar(int[] numbers)
    {
        Array.Sort(numbers);
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}