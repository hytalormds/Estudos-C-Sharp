using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        List<Produto> produtos = new List<Produto>();
        HashSet<string> nomes = new HashSet<string>();
        HashSet<string> codigosBarras = new HashSet<string>();

        InputDados(produtos, nomes, codigosBarras);
        ExibirDados(produtos);
    }
    public static void InputDados(List<Produto> produtos, HashSet<string> nomes, HashSet<string> codigoBarras)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o código de barras do produto: ");
            string codigo = Console.ReadLine().ToUpper();

            if (nome == "SAIR" || codigo == "0")
            {
                break;
            }

            if (nomes.Contains(nome) || codigoBarras.Contains(nome))
            {
                Console.WriteLine("Produto já cadastrado. Tente novamente.");
                continue;
            }
            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Produto produto = new Produto
            {
                Nome = nome,
                CodigoBarras = codigo,
                Quantidade = quantidade,
                Preco = preco
            };
            produtos.Add(produto);
            nomes.Add(nome);
            codigoBarras.Add(codigo);
        }
    }
    public static void ExibirDados(List<Produto> produtos)
    {
        Console.WriteLine("Produtos cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Código de Barras: {produto.CodigoBarras}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco:C}");
        }
    }
}