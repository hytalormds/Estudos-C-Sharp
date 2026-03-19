public class Pedido
{
    public string Nome { get; private set; }
    public int Quantidade { get; private set; }

    public Pedido(string nome, int quantidade)
    {
        if(string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome do pedido não pode ser vazio.", nameof(nome));

        if(quantidade <= 0)
            throw new ArgumentException("A quantidade deve ser maior que zero.", nameof(quantidade));

        Nome = nome;
        Quantidade = quantidade;
    }

    public void TotalPedido()
    {
        Console.WriteLine($"O total do pedido de {Nome} é: {Quantidade * 10:C}");
    }
}