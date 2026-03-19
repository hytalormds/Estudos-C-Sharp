public class Produto
{
    public int Quantidade { get; private set; }
    public string Nome { get; private set; }
     
    public Produto(string nome, int quantidade)
    {
        if (string.IsNullOrEmpty(nome))
            throw new ArgumentException("O nome do produto não pode ser nulo");
        if (quantidade < 0)
            throw new ArgumentException("A quantidade do produto não pode ser negativa");

        Nome = nome;
        Quantidade = quantidade;
    }
}