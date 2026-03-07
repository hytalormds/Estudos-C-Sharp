class Program
{
    public static void Main()
    {
        int n1 = InputNumber();
        int n2 = InputNumber();
        int n3 = InputNumber();

        Media(n1, n2, n3);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite um número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static void Media(int n1, int n2, int n3)
    {
        Console.WriteLine($"Média: {(n1+n2+n3)/3}");
    }
}