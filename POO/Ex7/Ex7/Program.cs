class Program
{
    public static void Main()
    {
        Livro livro1 = new Livro();
        livro1.Titulo = "O Senhor dos Anéis";
        livro1.Autor = "J.R.R. Tolkien";
        livro1.Paginas = 1178;

        livro1.ExibirInformacoes();
    }
}