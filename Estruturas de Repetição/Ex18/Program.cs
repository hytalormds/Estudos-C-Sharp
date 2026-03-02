class Program
{
    public static void Main()
    {
        string op = "N";

        while (op.ToUpper() != "S")
        {
            Console.WriteLine("Digite a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite a temperatura em  Celsius: ");
                double Celsius = int.Parse(Console.ReadLine());

                Console.WriteLine($"Conversão: {(9 * Celsius + 160) / 5}");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite a temperatura em  Fahrenheit: ");
                double Fahrenheit = int.Parse(Console.ReadLine());

                Console.WriteLine($"Conversão: {(Fahrenheit - 32) * 5 / 9}");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Digite a altura [MASCULINO]: ");
                double altM = double.Parse(Console.ReadLine());

                Console.WriteLine($"Peso Ideal [Masculino]: {(72.7 * altM) - 58}");
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Digite a altura [FEMININO]: ");
                double altF = double.Parse(Console.ReadLine());

                Console.WriteLine($"Peso Ideal [Feminino]: {(62.1 * altF) - 44.7}");
            }
            Console.WriteLine("Deseja Continuar? [S/N]: ");
            op = Console.ReadLine().ToUpper();
        }
    }
}