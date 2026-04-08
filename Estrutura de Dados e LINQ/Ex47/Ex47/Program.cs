using System.Collections.Generic;

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
            Console.WriteLine("Digite o pedido (digite sair para encerrar)");
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
        string pedidoAtendido = pedidos.Dequeue();
        Console.WriteLine($"Pedido Atendido: {pedidoAtendido}");
    }
}