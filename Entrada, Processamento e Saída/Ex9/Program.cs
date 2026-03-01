class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Igual: {n1==n2}");
        Console.WriteLine($"Não Igual: {n1!=n2}");
        Console.WriteLine($"Maior: {n1>n2}");
        Console.WriteLine($"Menor: {n1<n2}");
        Console.WriteLine($"Maior ou Igual: {n1>=n2}");
        Console.WriteLine($"Menor ou Igual: {n1<= n2}");
    }
}