class Program
{
    public static void Main()
    {
        Estoque estoque = new Estoque();
        string opcao;

        do
        {
            Console.WriteLine("\n1 - Adicionar produto");
            Console.WriteLine("2 - Remover produto");
            Console.WriteLine("3 - Listar produtos");
            Console.WriteLine("4 - Sair");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    var dados = InputDados();

                    try
                    {
                        Produto produto = new Produto(dados.nome, dados.quantidade);
                        estoque.AdicionarProduto(produto);

                        Console.WriteLine("Produto adicionado!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;

                case "2":
                    Console.WriteLine("Digite o nome do produto que deseja remover:");
                    string nomeRemover = Console.ReadLine();

                    estoque.RemoverProdutoPorNome(nomeRemover);
                    break;

                case "3":
                    estoque.ExibirProdutos();
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != "4");
    }

    public static (string nome, int quantidade) InputDados()
    {
        Console.WriteLine("Digite o nome do Produto:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a quantidade:");
        int quantidade = int.Parse(Console.ReadLine());

        return (nome, quantidade);
    }
}