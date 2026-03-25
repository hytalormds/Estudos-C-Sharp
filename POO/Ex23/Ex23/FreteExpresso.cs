class FreteExpresso : IFrete
{
    public double CalcularFrete(double valor, double peso)
    {
        double taxa = 12;
        return (valor * peso) + taxa;
    }
}