class Program
{
    public static void Main()
    {
        string name = InputName();
        Name(name);
    }
    public static string InputName()
    {
        Console.WriteLine("Digite o nome: ");
        string name = Console.ReadLine();
        return name;
    }

    public static void Name(string name)
    {
        Console.WriteLine($"Olá, {name}");
    }
}