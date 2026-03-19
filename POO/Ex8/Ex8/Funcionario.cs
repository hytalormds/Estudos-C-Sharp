class Funcionario
{
    public string Nome;
    public double Salario;

    public double AumentarSalario(double aumento)
    {
        return Salario += aumento;
    }
}