class ContaPoupanca : Conta
{
    public double Rendimento { get; set; }

    public void AplicarRendimento()
    {
        Saldo += Saldo * Rendimento;
    }
}