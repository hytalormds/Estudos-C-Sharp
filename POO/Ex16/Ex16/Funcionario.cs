class Funcionario
{
    public string Nome { get; private set; }
    public double Salario { get; private set; }

    public Funcionario (string nome, double salario)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome do funcionário não pode ser vazio.", nameof(nome));

        if (salario <= 0)
            throw new ArgumentException("O salário n");

        Nome = nome;
        Salario = salario;
    }

    public double CalcularBonus(double bonus)
    {
        return Salario + (Salario * (bonus/100));
    }
}