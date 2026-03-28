class Conta
{
    public int NumeroConta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public double Depositar (double valor)
    {
        Saldo += valor;
        return Saldo;
    }

    public virtual double Sacar (double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return Saldo;
        }
        Saldo -= valor;
        return Saldo;
    }
}