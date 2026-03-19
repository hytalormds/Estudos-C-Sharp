class Temperatura
{
    public double Celsius;
    public double Fahrenheit;

    public double CelsiusParaFahrenheit(double Celsius)
    {
        return (Celsius * 9 / 5) + 32;
    }

    public double FahrenheitParaCelsius(double Fahrenheit)
    {
        return (Fahrenheit - 32) * 5 / 9;
    }
}