using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        List<Produto> produtos = new List<Produto>();
        HashSet<string> nomes = new HashSet<string>();

        InputProdutos(produtos, nomes);
        RemoverProdutos(produtos, nomes);
    }
    public static void InputProdutos(List<Produto> produtos, HashSet<string> nomes)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine().ToUpper();

            if (nome == "SAIR")
            {
                break;
            }

            if (nomes.Contains(nome))
            {
                Console.WriteLine("Produto já existe. Digite outro nome.");
                continue;
            }

            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Produto produto = new Produto
            {
                Nome = nome,
                Quantidade = quantidade,
                Preco = preco
            };

            produtos.Add(produto);
            nomes.Add(nome);
        }
    }
    public static void RemoverProdutos(List<Produto> produtos, HashSet<string> nomes)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do produto a ser removido: ");
            string nomeRemovido = Console.ReadLine().ToUpper();

            if (nomeRemovido == "SAIR")
            {
                break;
            }

            var produto = produtos.Find(p => p.Nome == nomeRemovido);

            if (nomes.Contains(nomeRemovido)) {
                produtos.Remove(produto);
                nomes.Remove(nomeRemovido);

                Console.WriteLine($"Produto '{nomeRemovido}' removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }
            }
        }
    }