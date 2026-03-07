class Program
{
    public static void Main()
    {
        int n = InputNumber();
        VerificaNumero(n);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite um valor: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    public static void VerificaNumero(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Número Par");
        }
        else
        {
            Console.WriteLine("Número ímpar");
        }
    }
}