class Program
{
    public static void Main()
    {
        (string nome, double salario, double bonus) = InputNumber();
        Funcionario func = new Funcionario(nome, salario);

        double bonusCalculado = func.CalcularBonus(bonus);

        Console.WriteLine("[EXIBIÇÃO]");
        Console.WriteLine($"Funcionário: {func.Nome}");
        Console.WriteLine($"Salário: {func.Salario}");
        Console.WriteLine($"Bônus: {bonus}");
        Console.WriteLine($"Salário Com Bônus: {bonusCalculado}");
    }
    public static (string nome, double salario, double bonus) InputNumber()
    {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o bônus: ");
            double bonus = double.Parse(Console.ReadLine());

            return (nome, salario, bonus);
        }
    }

