class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public double Depositar(double valor)
    {
        return Saldo += valor;
    }

    public double Sacar(double valor)
    {
        return Saldo -= valor;
    }
}