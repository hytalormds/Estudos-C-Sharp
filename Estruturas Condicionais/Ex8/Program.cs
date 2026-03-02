class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um código [1, 2, 3]: ");
        int cd = int.Parse(Console.ReadLine());

        if (cd == 1 || cd == 2 || cd == 3)
        {
            switch (cd)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Código Inválido");
        }
    }
}