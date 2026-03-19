class Program
{
    public static void Main()
    {
        (double value, double sacar) dados = InputValue();
        ExibirMensagem(dados.value, dados.sacar);
    }

    public static (double value, double sacar) InputValue()
    {
        Console.WriteLine("Digite o valor a ser depositado: ");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor a ser sacado: ");
        double sacar = double.Parse(Console.ReadLine());

        return (valor, sacar);
    }

    public static void ExibirMensagem(double valor, double sacar)
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(valor);
        conta.Sacar(sacar);

        Console.WriteLine($"Valor depositado: {valor}");
        Console.WriteLine($"Saldo atual: {conta.Saldo}");
    }
}