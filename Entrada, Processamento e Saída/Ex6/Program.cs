class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a temperatura em Fahrenheit: ");
        float fahrenheit = float.Parse(Console.ReadLine());

        Console.WriteLine($"A temperatura em Celsius: {(fahrenheit-32)*5/9}");
    }
}