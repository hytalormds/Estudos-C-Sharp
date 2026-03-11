class Program
{
    public static void Main()
    {
        (double salario, int reajuste) dados = InputDados();
        CalculoReajuste(dados.salario, dados.reajuste);
    }
    public static (double, int) InputDados()
    {
        Console.WriteLine("Digite o salário: ");
        double salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a % do reajuste: ");
        int reajuste = int.Parse(Console.ReadLine());

        return (salario, reajuste);
    }
    public static void CalculoReajuste(double salario, int reajuste)
    {
        Console.WriteLine($"Salário Atualizado: {(salario + (salario * reajuste / 100))}");
    }
}