public class Estoque
{

    List <Produto> listaProdutos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        listaProdutos.Add(produto);
    }

    public void RemoverProdutoPorNome(string nome)
    {
        var produto = listaProdutos
            .Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (produto != null)
        {
            listaProdutos.Remove(produto);
            Console.WriteLine("Produto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    public void ExibirProdutos()
    {
        Console.WriteLine("Produtos em estoque:");
        foreach (var produto in listaProdutos)
        {
            Console.WriteLine($"Produto: {produto.Nome}, Quantidade: {produto.Quantidade}");
        }
    }
}