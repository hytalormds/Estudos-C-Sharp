class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a idade em dias: ");
        int dias = int.Parse(Console.ReadLine());

        Console.WriteLine($"Idade em dias: {(anos*365)+(meses*30)+dias}");
    }
}