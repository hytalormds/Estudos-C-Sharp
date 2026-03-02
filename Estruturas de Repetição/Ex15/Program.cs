class Program
{
    public static void Main()
    {
        string op = "N";

        while (op.ToUpper() != "S")
        {
            Console.WriteLine("Digite o índice de poluição: ");
            if (double.TryParse(Console.ReadLine(), out double id))
            {
                if (id <= 0.3)
                {
                    Console.WriteLine("Indústria 1 - NOTIFICADA");
                }
                else if (id <= 0.4)
                {
                    Console.WriteLine("Indústria 1 e 2 - NOTIFICADAS");
                }
                else if (id <= 0.5)
                {
                    Console.WriteLine("Todas as indústrias - NOTIFICADAS");
                }
                else
                {
                    Console.WriteLine("Índice acima do limite permitido!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número.");
            }

            Console.WriteLine("Deseja Continuar? [S/N]");
            op = Console.ReadLine().ToUpper();
        }
    }
}
