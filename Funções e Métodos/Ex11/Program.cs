class Program
{
    public static void Main()
    {
        int number = InputNumber();
        int resultado = CalculaFatorial(number);

        Console.WriteLine($"O fatorial de {number} é {resultado}");
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite o número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static int CalculaFatorial(int number)
    {
        int i = 1;
        int resultado = 1;

        while (i <= number)
        {
            resultado *= i;
            i++;
        }
        return resultado;
    }
}