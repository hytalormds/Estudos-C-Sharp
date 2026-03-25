class Biblioteca
{
    public string Nome { get; private set; }
    public int Quantidade { get; private set; }

    public Biblioteca (string nome, int quantidade)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome da biblioteca não pode ser vazio.", nameof(nome));

        if (quantidade < 0)
            throw new ArgumentException("A quantidade de livros não pode ser negativa.", nameof(quantidade));

        Nome = nome;
        Quantidade = quantidade;
    }

    public void EmprestarLivro()
    {
        if (Quantidade > 0)
        {
            Quantidade--;
            Console.WriteLine($"Livro emprestado. Quantidade restante: {Quantidade}");
        }
        else
        {
            Console.WriteLine("Quantidade de livros inválida. Não pode ser negativa.");
        }
    }

    public void DevolverLivro()
    {
        Quantidade++;
        Console.WriteLine($"Livro devolvido. Quantidade atual: {Quantidade}");
    }
}