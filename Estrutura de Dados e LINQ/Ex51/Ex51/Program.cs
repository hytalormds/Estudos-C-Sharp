using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> pedidos = new Queue<string>();
        InputQueue(pedidos);
        ExibirQueue(pedidos);
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
    public static void ExibirQueue(Queue<string> pedidos)
    {
        foreach (var item in pedidos)
        {
            Console.WriteLine(item);
        }
    }
}