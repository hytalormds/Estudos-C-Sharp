class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma opção: ");
        int op = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número: ");
        int n2 = int.Parse(Console.ReadLine());

        if (op == 1)
        {
            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("Múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
        else if (op == 2)
        {
            if (n1 % 2 == 0 || n2 % 2 == 0)
            {
                Console.WriteLine("Números Pares");
            }
        }
        else if (op == 3)
        {
            if ((n1 + n2) / 2 >= 7)
            {
                Console.WriteLine("Média maior que 7");
            }
            else
            {
                Console.WriteLine("Média menor que 7");
            }
        }
        else if (op == 4)
        {
            {
                Console.WriteLine("Encerrando...");
            }
        }
    }
}