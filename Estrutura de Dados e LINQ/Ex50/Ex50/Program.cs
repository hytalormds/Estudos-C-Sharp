using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> pedidos = new Queue<string>();
        InputQueue(pedidos);
        TryQueue(pedidos);
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
    public static void TryQueue(Queue<string> pedidos)
    {
        try
        {
            string pedidoRemover = pedidos.Dequeue();
            Console.WriteLine($"Pedido Removido: {pedidoRemover}");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("A fila está vazia. Não é possível remover um pedido.");
        }
    }
}