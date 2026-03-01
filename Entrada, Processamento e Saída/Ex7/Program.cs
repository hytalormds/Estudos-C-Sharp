class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o Raio: ");
        float raio = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Altura: ");
        float altura = float.Parse(Console.ReadLine());

        Console.WriteLine($"Volume: {3.14*raio*raio*altura}");
    }
}