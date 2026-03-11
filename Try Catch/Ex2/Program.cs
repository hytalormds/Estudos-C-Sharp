class Program
{
    public static void Main()
    {
        int number = InputNumber();
        ExibirNumero(number);
    }
    public static int InputNumber()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite um número: ");
                int number = int.Parse(Console.ReadLine());
                return number;
            }catch (FormatException)
            {
                Console.WriteLine("Erro: Digite apenas números");
            }
        }
    }
    public static void ExibirNumero(int number)
    {
        Console.WriteLine($"Número: {number}");
    }
}