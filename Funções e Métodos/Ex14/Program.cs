class Program
{
    public static void Main()
    {
        int basePotencia = InputPotencia();
        int expoente = InputExpoente();
        CalculaPotencia(basePotencia, expoente);
    }

    public static int InputPotencia()
    {
        Console.WriteLine("Digite a base: ");
        int basePotencia = int.Parse(Console.ReadLine());

        return basePotencia;
    }

    public static int InputExpoente()
    {
        Console.WriteLine("Digite o expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        return expoente;
    }

    public static void CalculaPotencia(int basePotencia, int expoente)
    {
        Console.WriteLine($"O calculo da potência e: {Math.Pow(basePotencia, expoente)}");
    }
}