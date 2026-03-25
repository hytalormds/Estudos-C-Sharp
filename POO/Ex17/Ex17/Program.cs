class Program
{
    public static void Main()
    {
        (double value, double sacar, double limite) dados = InputValue();
        ExibirMensagem(dados.value, dados.sacar, dados.limite);
    }

    public static (double value, double sacar, double limite) InputValue()
    {
        Console.WriteLine("Digite o valor a ser depositado: ");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor a ser sacado: ");
        double sacar = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do limite: ");
        double limite = double.Parse(Console.ReadLine());

        return (valor, sacar, limite);
    }

    public static void ExibirMensagem(double valor, double sacar, double limite)
    {
        ContaCorrente conta = new ContaCorrente(limite);
        conta.Depositar(valor);
        conta.Sacar(sacar);

        Console.WriteLine($"Valor depositado: {valor}");
        Console.WriteLine($"Saldo atual: {conta.Saldo}");
        Console.WriteLine($"Limite: {conta.Limite}");
    }
}