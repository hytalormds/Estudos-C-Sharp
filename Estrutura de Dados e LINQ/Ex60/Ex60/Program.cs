class Program
{
    public static void Main()
    {
        Queue<Pedido> pedidos = new Queue<Pedido>();
        List<Pedido> pedidosEntregues = new List<Pedido>();
        AdicionarPedido(pedidos);
        EntregarPedido(pedidos, pedidosEntregues);
    }
    public static void AdicionarPedido(Queue<Pedido> pedidos)
    {
        while (true)
        {
            Console.Write("Digite o pedido: ");
            string nome = Console.ReadLine().ToUpper();

            if (nome == "SAIR")
            {
                break;
            }

            Pedido pedido = new Pedido
            {
                Tarefa = nome,
            };
            pedidos.Enqueue(pedido);
        }
    }
    public static void EntregarPedido(Queue<Pedido> pedidos, List<Pedido> pedidosEntregues)
    {
        while (true)
        {
            Console.Write("Deseja continuar? [S/N]: ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "N")
            {
                break;
            }
            var removido = pedidos.Dequeue();
            pedidosEntregues.Add(removido);
             Console.WriteLine($"Pedido {removido.Tarefa} entregue!");
        }
    }
}