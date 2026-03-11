class Program
{
    public static void Main()
    {
        int n = InputNumber();
        VerificaNumber(n);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite o número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    public static void VerificaNumber(int n)
    {
        if(n % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("ÍMPAR");
        }
    }
}