class Program
{
    public static void Main()
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Digite o nome do funcionário:");
        funcionario.Nome = Console.ReadLine();

        Console.WriteLine("Digite o salário atual:");
        funcionario.Salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o aumento do salário:");
        double aumento = double.Parse(Console.ReadLine());

        funcionario.AumentarSalario(aumento);

        Console.WriteLine($"O novo salário de {funcionario.Nome} é: {funcionario.Salario}");
    }
}