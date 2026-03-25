class Program
{
    public static void Main()
    {
        (string nome, double preco, int quantidade) dados = InputDados();
        ItemPedido item = new ItemPedido(dados.nome, dados.preco, dados.quantidade);

        Pedido pedido = new Pedido();

        pedido.Itens.Add(item);

        double total = pedido.CalcularTotal();

        Console.WriteLine($"O total do pedido é: {total}");
    }
    public static (string nome, double preco, int quantidade) InputDados() {
        Console.WriteLine("Digite o nome do item:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o preço do item:");
        double preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade do item:");
        int quantidade = int.Parse(Console.ReadLine());

        return (nome, preco, quantidade);
    }
}