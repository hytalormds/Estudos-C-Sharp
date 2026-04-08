using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> pedidos = new Queue<string>();
        InputQueue(pedidos);
        CountQueue(pedidos);
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
    public static void CountQueue(Queue<string> pedidos)
    {
        Console.WriteLine($"Total de Pedidos: {pedidos.Count()}");
    }
}