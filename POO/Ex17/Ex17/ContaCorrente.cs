class ContaCorrente : ContaBancaria
{
    public double Limite { get; private set; }

    public ContaCorrente (double limite)
    {
        if (limite <= 0)
            throw new Exception("O limite deve ser maior que 0");
        
        Limite = limite;
    }

    public new double Sacar(double valor
)
    {
        if (Saldo + Limite >= valor)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }

        return Saldo;
    }
}