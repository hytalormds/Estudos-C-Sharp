class Program
{
    public static void Main()
    {
        (int n1, int n2) = InputNumbers();
        int resultado = Somar(n1, n2);
        Console.WriteLine(resultado);
    }
    public static (int, int) InputNumbers()
    {
        Console.WriteLine("Digite um número: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número: ");
        int number2 = int.Parse(Console.ReadLine());

        return(number1, number2);
    }

    public static int Somar(int number1, int number2)
    {
        return number1 + number2;
    }
}