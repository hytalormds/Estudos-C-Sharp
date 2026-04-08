class Program
{
    public static void Main()
    {
        Queue<Pedido> normal = new Queue<Pedido>();
        Queue<Pedido> propriedade = new Queue<Pedido>();
        InputQueue(normal, propriedade);
        Atender(normal, propriedade);
    }
    public static void InputQueue(Queue<Pedido> normal, Queue<Pedido> propriedade)
    {
        while (true)
        {
            Console.WriteLine("Nome do pedido: ");
            string tarefa = Console.ReadLine().ToUpper();

            if (tarefa == "SAIR")
            {
                break;
            }

            Console.WriteLine("Tipo: 1 - Normal | 2 - Propriedade");
            int tipo = int.Parse(Console.ReadLine());

            Pedido pedido = new Pedido { Tarefa = tarefa };

            if (tipo == 1)
            {
                propriedade.Enqueue(pedido);
                Console.WriteLine("Pedido adicionado à fila de propriedade.");
            }
            else
            {
                normal.Enqueue(pedido);
                Console.WriteLine("Pedido adicionado à fila normal.");
            }
        }
    }
    public static void Atender(Queue<Pedido> normal, Queue<Pedido> prioridade)
    {
        if (prioridade.Count > 0)
        {
            var pedido = prioridade.Dequeue();  
            Console.WriteLine($"Atendendo pedido de propriedade: {pedido.Tarefa}");
        }else if (normal.Count > 0)
        {
            var pedido = normal.Dequeue();
            Console.WriteLine($"Atendendo pedido normal: {pedido.Tarefa}");
        }
    }
}