class Program
{
    static void Calcular(int a, int b, out int soma, out int produto)
    {
        soma = a + b;
        produto = a * b;
    }

    static void Main()
    {
        int x = 5;
        int y = 3;
        int resultadoSoma, resultadoProduto;

        Calcular(x, y, out resultadoSoma, out resultadoProduto);

        Console.WriteLine($"Soma: {resultadoSoma}");
        Console.WriteLine($"Produto: {resultadoProduto}");
    }
}
