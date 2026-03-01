class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a temperatura em Celsius: ");
        float celsius = float.Parse(Console.ReadLine());

        Console.WriteLine($"Fahrenheit: {(9 * celsius + 160) / 5}");
    }
}