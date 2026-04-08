
class Program
{
    public static void Main()
    {
        Queue<string> pedidos = new Queue<string>();

        while (true)
        {

            Console.WriteLine("Digite a opção: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    InputQueue(pedidos);
                    break;
                case 2:
                    RemoveQueue(pedidos);
                    break;
                case 3:
                    DisplayQueue(pedidos);
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

    public static void InputQueue(Queue<string> pedidos)
    {
        while (true)
        {
            Console.WriteLine("Digite o pedido: ");
            string pedido = Console.ReadLine().ToUpper();

            if(pedido == "SAIR")
            {
                break;
            }

            pedidos.Enqueue(pedido);
        }
    }
    public static void RemoveQueue(Queue<string> pedidos)
    {
        if(pedidos.Count() > 0)
        {
            string atenderPedido = pedidos.Dequeue();
            Console.WriteLine($"Atendendo o pedido: {atenderPedido}");
        }
        else
        {
            Console.WriteLine("Não é possível atender ao pedido");
        }
    }
    public static void DisplayQueue(Queue<string> pedidos)
    {
        Console.WriteLine("Pedidos na fila: ");
        foreach (string pedido in pedidos)
        {
            Console.WriteLine(pedido);
        }
    }
}