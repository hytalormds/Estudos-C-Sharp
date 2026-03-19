class Program
{
    public static void Main()
    {
        Temperatura temp = new Temperatura();

        temp.Celsius = 45;
        temp.Fahrenheit = 113;

        double celsius = temp.CelsiusParaFahrenheit(temp.Celsius);
        double fahrenheit = temp.FahrenheitParaCelsius(temp.Fahrenheit);

        Console.WriteLine($"Celsius: {celsius}");
        Console.WriteLine($"Fahrenheit: {fahrenheit}");
    }
}