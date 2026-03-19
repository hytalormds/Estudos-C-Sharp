class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotal()
    {
        return Preco * Quantidade;
    }

    public void Exibir()
    {
        Console.WriteLine($"Valor Total: {ValorTotal()}");
    }
}
