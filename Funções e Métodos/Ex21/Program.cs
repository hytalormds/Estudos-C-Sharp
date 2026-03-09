class Program
{
    public static void Main()
    {
        int n = InputNumber();
        Fibonacci(n);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite a quantidade de números: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static void Fibonacci(int number)
    {
        int first = 0, second = 1, next;

        for (int i = 2; i < number; i++)
        {
            next = first + second;
            Console.WriteLine(next);
            first = second;
            second = next;
        }
    }
}