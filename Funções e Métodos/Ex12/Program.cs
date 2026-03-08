class Program
{
    public static void Main()
    {
        int number = InputNumber();
        VerificaPar(number);
    }

    public static int InputNumber()
    {
        Console.WriteLine("Digite o número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static void VerificaPar(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if(i % 2  == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}