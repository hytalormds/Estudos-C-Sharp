class Aluno
{
    public string Nome;
    public int Nota1;
    public int Nota2;

    public double Media()
    {
        return (Nota1 + Nota2) / 2;
    }
}