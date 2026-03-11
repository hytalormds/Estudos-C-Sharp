class Program
{
    public static void Main()
    {
        (double number1, double number2) dados = InputNumber();
        SumNumbers(dados.number1, dados.number2);
    }
    public static (double number1, double number2) InputNumber()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite o primeiro número: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int number2 = int.Parse(Console.ReadLine());

                return (number1, number2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite apenas números");
            }
        }
    }
    public static void SumNumbers(double number1, double number2)
    {
        Console.WriteLine($"Soma: {number1+number2}");
    }
}