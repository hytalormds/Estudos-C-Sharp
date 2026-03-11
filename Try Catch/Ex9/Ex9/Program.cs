class Program
{
    public static void Main()
    {
        (int qtd, double preco, string produto) dados = InputDados();
        ExibirProduto(dados.qtd, dados.preco, dados.produto);
    }
    public static (int qtd, double preco, string produto) InputDados()
    {

        while (true)
        {
            try
            {
                Console.Write("Digite o produto: ");
                string produto = Console.ReadLine();

                Console.Write("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                Console.Write("Digite o preço: ");
                double preco = double.Parse(Console.ReadLine());

                if (qtd < 0 || preco < 0 || string.IsNullOrEmpty(produto))
                {
                    throw new Exception();
                }

                Console.Write("Deseja continuar? (S/N): ");
                string op = Console.ReadLine().ToUpper();

                if (op == "N")
                {
                    return (qtd, preco, produto);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Valor inválido, tente novamente.");
                continue;
            }
        }
    }

    public static void ExibirProduto(int qtd, double preco, string produto)
    {
        Console.WriteLine($"Produto: {produto}");
        Console.WriteLine($"Quantidade: {qtd}");
        Console.WriteLine($"Preço: {preco}");
    }
}