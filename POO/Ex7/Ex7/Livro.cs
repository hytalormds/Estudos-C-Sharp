class Livro
{
    public string Titulo;
    public string Autor;
    public int Paginas;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Número de páginas: {Paginas}");
    }
}