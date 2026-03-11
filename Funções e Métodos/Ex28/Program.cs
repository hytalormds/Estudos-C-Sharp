class Program
{
    public static void Main()
    {
        (double baseVal, double alturaVal) dados = InputDados();
        CalculoHipotenusa(dados.baseVal, dados.alturaVal);
    }

    public static (double baseVal, double alturaVal) InputDados()
    {
        Console.WriteLine("Digite a base: ");
        double baseVal = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura: ");
        double alturaVal = double.Parse(Console.ReadLine());

        return (baseVal, alturaVal);
    }

    public static void CalculoHipotenusa(double baseVal, double alturaVal)
    {
        double hipotenusa = Math.Sqrt(Math.Pow(baseVal, 2) + Math.Pow(alturaVal, 2));
        Console.WriteLine($"A hipotenusa é: {hipotenusa}");
    }
}
