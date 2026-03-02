class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor B: ");
        int b = int.Parse(Console.ReadLine());

        int aux;

        aux = a;
        a = b;
        b = aux;

        Console.WriteLine("A: " + a);
        Console.WriteLine("B " + b);
    }
}