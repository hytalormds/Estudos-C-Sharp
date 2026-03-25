class Program
{
    public static void Main()
    {
        (double a, double b, double c) dados = InputDados();
        Triangulo triangulo = new Triangulo(dados.a, dados.b, dados.c);

        triangulo.TipoTriangulo();
    }
    public static (double a, double b, double c) InputDados()
    {
        Console.WriteLine("Digite os lados do triângulo:");
        Console.Write("Lado A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Lado B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Lado C: ");
        double c = double.Parse(Console.ReadLine());
        return (a, b, c);
    }
}