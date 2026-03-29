using System.Collections.Generic;

class Produto
{
    string Nome { get; set; }
    List<string> produtos { get; set; }

    public Produto()
    {
        produtos = new List<string>();
    }

    public void AdicionarProduto(string nome)
    {
        produtos.Add(nome);
    }

    public void ExibirProdutos()
    {
        foreach (var item in produtos)
        {
            Console.WriteLine(item);
        }
    }
}