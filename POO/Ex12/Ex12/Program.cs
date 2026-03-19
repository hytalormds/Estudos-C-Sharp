class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria("João Silva", 1000m);

        decimal deposito = conta.Depositar(500m);
        decimal sacar = conta.Sacar(200m);

        Console.WriteLine($"Titular: {conta.Titular}");
        Console.WriteLine($"Saldo após depósito: {deposito}");
        Console.WriteLine($"Saldo após saque: {sacar}");
    }
}