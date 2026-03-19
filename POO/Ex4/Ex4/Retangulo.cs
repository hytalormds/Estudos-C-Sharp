class Retangulo
{
    public double Base;
    public double Altura;

    public double CalcularArea()
    {
        return Base * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2*(Base + Altura);
    }
}