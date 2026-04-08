class Program
{
    public static void Main()
    {
        Queue<Pedido> filaPedidos = new Queue<Pedido>();
        InputQueue(filaPedidos);
        DisplayQueue(filaPedidos);
    }
    public static void InputQueue(Queue<Pedido> filaPedidos)
    {
        while (true)
        {
            Console.WriteLine("Digite o pedido: ");
            string pedido = Console.ReadLine().ToUpper();

            if (pedido == "SAIR")
            {
                break;
            }
            filaPedidos.Enqueue(new Pedido
            {
                NomeProduto = pedido
            });
        }
    }
    public static void DisplayQueue(Queue<Pedido> filaPedidos)
    {
        Console.WriteLine("Pedidos na fila: ");
        foreach (var pedido in filaPedidos)
        {
            Console.WriteLine(pedido.NomeProduto);
        }
    }
}