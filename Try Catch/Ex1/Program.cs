class Program
{
    public static void Main()
    {
        int number1 = InputNumber();
        int number2 = InputNumber();

        Divisao(number1, number2);
    }

    public static int InputNumber()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite um número:");
                int number = int.Parse(Console.ReadLine());
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite apenas números.");
            }
        }
    }

    public static void Divisao(int number1, int number2)
    {
        try
        {
            Console.WriteLine($"Resultado: {number1 / number2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Não é possível dividir por zero.");
        }
    }
}