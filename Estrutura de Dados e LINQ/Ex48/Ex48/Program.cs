using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> pedidos =  new Queue<string>();
        InputQueue(pedidos);
        ExibirQueue(pedidos);
    }
    public static void InputQueue(Queue<string> pedidos)
    {
        while (true)
        {
            Console.WriteLine("Digite o pedido (digite sair para encerrar): ");
            string pedido = Console.ReadLine().ToUpper();

            if (pedido == "SAIR")
            {
                break;
            }

            pedidos.Enqueue(pedido);
        }
    }
    public static void ExibirQueue(Queue<string> pedidos)
    {
        string proximoPedido = pedidos.Peek();
        Console.WriteLine($"Próximo Pedido: {proximoPedido}");
    }
}