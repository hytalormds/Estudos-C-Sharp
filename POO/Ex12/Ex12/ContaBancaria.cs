public class ContaBancaria
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    public ContaBancaria (string titular, decimal saldo)
    {
        if(string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("O titular da conta não pode ser vazio.", nameof(titular));

        if (Saldo < 0)
            throw new ArgumentException("O saldo inicial não pode ser negativo.", nameof(Saldo));

        Titular= titular;
        Saldo = saldo;
    }

    public decimal Depositar (decimal valor) { 
        return Saldo += valor;
    }

    public decimal Sacar (decimal valor)
    {
        return Saldo -= valor;
    }
}