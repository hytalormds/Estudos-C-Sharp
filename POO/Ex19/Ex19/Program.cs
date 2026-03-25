class Program
{
    public static void Main()
    {
        (string nome, int quantidade) dados = InputDados();
        Biblioteca biblioteca = new Biblioteca(dados.nome, dados.quantidade);

        biblioteca.EmprestarLivro();
        biblioteca.DevolverLivro();
    }
    public static (string nome, int quantidade) InputDados()
    {
        Console.Write("Digite o nome do livro: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a quantidade de livros: ");
        int quantidade = int.Parse(Console.ReadLine());

        return (nome, quantidade);
    }
}