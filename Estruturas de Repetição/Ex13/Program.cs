class Program
{
    public static void Main()
    {
        string op = "N";
        double salario, e;

        while (op != "S")
        {
            Console.WriteLine("Digite o código: ");
            string c = Console.ReadLine();

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int n = int.Parse(Console.ReadLine());

            salario = n * 10.00;

            if (n > 50)
            {
                e = n * 20.00;
            }
            else
            {
                e = 0;
            }
            Console.WriteLine($"Salário Total: {salario}");
            Console.WriteLine($"Salário Excedente: {e}");

            Console.WriteLine("Deseja Continuar? [S/N]");
            op = Console.ReadLine();
        }
    }
}