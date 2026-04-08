class Program
{
    public static void Main()
    {
        Queue<Pedido> tarefa = new Queue<Pedido>();
        List<Pedido> pedidos = new List<Pedido>();
        InputQueue(tarefa);
        RemoveQueue(tarefa, pedidos);
        DisplayQueue(tarefa, pedidos);
    }
    public static void InputQueue(Queue<Pedido> tarefa)
    {
        while (true)
        {
            Console.Write("Digite o pedido: ");
            string nome = Console.ReadLine().ToUpper();

            if (nome == "SAIR")
            {
                break;
            }

            Pedido p = new Pedido
            {
                Tarefa = nome
            };
            tarefa.Enqueue(p);
        }
    }
    public static void RemoveQueue(Queue<Pedido> tarefa, List<Pedido> pedidos)
    {
        if (tarefa.Count > 0)
        {
            var pedidoAtendido = tarefa.Dequeue();
            pedidos.Add(pedidoAtendido);
            Console.WriteLine($"Pedido {pedidoAtendido.Tarefa} atendido.");
        }
    }
    public static void DisplayQueue(Queue<Pedido> tarefa, List<Pedido> pedidos)
    {
        Console.WriteLine("\nPedidos na fila:");
        foreach (var pedido in tarefa)
        {
            Console.WriteLine(pedido.Tarefa);
        }
        Console.WriteLine("\nPedidos atendidos:");
        foreach (var pedido in pedidos)
        {
            Console.WriteLine(pedido.Tarefa);
        }
    }
}