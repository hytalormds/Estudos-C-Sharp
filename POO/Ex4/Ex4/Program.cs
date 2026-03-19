class Program
{
    public static void Main()
    {
        Retangulo rt1 = new Retangulo();

        rt1.Base = 5;
        rt1.Altura = 3;

        Console.WriteLine($"Área: {rt1.CalcularArea()}");
        Console.WriteLine($"Perímetro: {rt1.CalcularPerimetro()}");
    }
}