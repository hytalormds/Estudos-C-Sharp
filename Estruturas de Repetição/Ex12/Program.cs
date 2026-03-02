class Program
{
    public static void Main()
    {
        string op = "S";

        while (op.ToUpper() == "S")
        {
            Console.WriteLine("Selecione uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Soma: {n1 + n2}");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Soma: {n1 - n2}");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Soma: {n1 * n2}");
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número: ");
                int n2 = int.Parse(Console.ReadLine());

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Inválida");
                }
                else
                {
                    Console.WriteLine($"Soma: {n1 / n2}");
                }
            }
            else
            {
                Console.WriteLine("Opção Inválida!");
            }
            Console.WriteLine("Deseja Continuar? [S/N]");
            op = Console.ReadLine();
        }
    }
}