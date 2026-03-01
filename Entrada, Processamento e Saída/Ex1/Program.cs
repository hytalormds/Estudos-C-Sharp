class Program
{
    public static void Main()
    {
        float etqMedio;

        Console.WriteLine("Digite a quantidade mínima: ");
        int qtdMinima = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade máxima: ");
        int qtdMaxima = int.Parse(Console.ReadLine());

        etqMedio = (qtdMinima + qtdMaxima)/2;

        Console.WriteLine("Estoque Médio: " + etqMedio);
    }
}