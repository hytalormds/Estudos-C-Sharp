class Program
{
    public static void Main()
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "João";
        aluno1.Nota1 = 7;
        aluno1.Nota2 = 8;

        double valor = aluno1.Media();

        Console.WriteLine(valor);
    }
}