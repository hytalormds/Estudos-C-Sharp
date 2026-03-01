class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a contação do dólar: ");
        float ctcDolar = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor em dólar: ");
        float dolar = float.Parse(Console.ReadLine());

        float conversao;

        conversao = ctcDolar * dolar;

        Console.WriteLine("O valor em reais é: " + conversao);
    }
}