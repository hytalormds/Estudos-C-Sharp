class Program
{
    public static void Main()
    {
        Console.WriteLine("Selecione uma opção: ");
        int op = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor: ");
        int n2 = int.Parse(Console.ReadLine());

        if (op == 1)
        {
            Console.WriteLine($"{n1 + n2}");
        }
        else if (op == 2)
        {
            Console.WriteLine($"{n1 - n2}");
        }
        else if (op == 3)
        {
            Console.WriteLine($"{n1 * n2}");
        }
        else if (op == 4)
        {
            Console.WriteLine($"{n1 / n2}");
        }
        else
        {
            Console.WriteLine("Opção Inválida");
        }
    }
}