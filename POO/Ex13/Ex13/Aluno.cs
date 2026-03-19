public class Aluno
{
    public string Nome { get; private set; }
    public int Nota1 { get; private set; }
    public int Nota2 { get; private set; }

    public Aluno (string nome, int nota1, int nota2)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome do aluno não pode ser vazio.", nameof(nome));

        if (nota1 < 0 || nota2 < 0)
            throw new ArgumentException("As notas não podem ser negativas.");

        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public double Media()
    {
        return (Nota1 + Nota2) / 2.0;
    }

    public bool Aprovado()
    {
        return Media() >= 7.0 ? true : false;
    }
}