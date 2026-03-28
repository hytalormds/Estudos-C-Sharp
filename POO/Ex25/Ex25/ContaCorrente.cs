class ContaCorrente : Conta
{
    public double Taxa { get; set; }
    public override double Sacar(double valor) 
    {
        double total = valor + Taxa;

        if (total > Saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return Saldo;
        }
        Saldo -= total;
        return Saldo;
    }
}