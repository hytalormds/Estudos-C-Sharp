class Program
{
    public static void Main()
    {
        Queue<string> pedidos = new Queue<string>();
        InputQueue(pedidos);
        RemoveQueue(pedidos);
    }
    public static void InputQueue(Queue<string> pedidos)
    {
        while (true)
        {
            Console.WriteLine("Digite o pedido: ");
            string pedido = Console.ReadLine().ToUpper();

            if (pedido == "SAIR")
            {
                break;
            }

            pedidos.Enqueue(pedido);
        }
    }
    public static void RemoveQueue(Queue<string> pedidos)
    {
        string removePedido = pedidos.Dequeue();
        Console.Write(removePedido);
    }
}