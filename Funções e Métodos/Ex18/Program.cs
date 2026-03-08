class Program
{
    public static void Main()
    {
        double celsius = InputTemp();
        Conversao(celsius);
    }
    public static double InputTemp()
    {
        Console.WriteLine("Digite a temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        return celsius;
    }

    public static void Conversao(double celsius)
    {
        Console.WriteLine($"A conversão de {celsius} celsius para fahrenheit e {(celsius*9/5)+32}");
    }
}