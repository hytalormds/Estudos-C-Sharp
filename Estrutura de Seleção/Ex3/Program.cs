class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a altura [h]: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o sexo da pessoa: ");
        string sexo = Console.ReadLine().ToUpper();

        if (sexo == "M")
        {
            Console.WriteLine($"{(72.7 * h) - 58}");
        }
        else if (sexo == "F")
        {
            {
                Console.WriteLine($"{(62.1 * h) - 44.7}");
            }
        }
        else
        {
            Console.WriteLine("Sexo Inválido");
        }
    }
}