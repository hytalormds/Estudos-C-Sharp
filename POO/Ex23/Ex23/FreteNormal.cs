class FreteNormal : IFrete
{
    public double CalcularFrete(double valor, double peso)
    {
        return valor * peso;
    }
}