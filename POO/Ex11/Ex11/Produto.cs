public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto(string nome, decimal preco, int quantidade)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("O nome do produto é obrigatório.");

        if (preco <= 0)
            throw new Exception("O preço deve ser maior que zero.");

        if (quantidade < 0)
            throw new Exception("Quantidade não pode ser negativa.");

        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public decimal Total()
    {
        return Preco * Quantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Total: {Total():C}");
    }
}