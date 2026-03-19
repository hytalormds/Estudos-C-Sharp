class Calculadora
{
    public double n1, n2;
    public int op;

    public double Soma(double n1, double n2, int op = 1)
    {
        return n1 + n2;
    }

    public double Subtracao(double n1, double n2, int op = 2)
    {
        return n1 - n2;
    }

    public double Multiplicacao(double n1, double n2, int op = 3)
    {
        return n1 * n2;
    }

    public double Divisao(double n1, double n2, int op = 4)
    {
        if (n2 == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        return n1 / n2;
    }
}