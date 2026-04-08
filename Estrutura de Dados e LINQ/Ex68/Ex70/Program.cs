class Program
{
    public static void Main()
    {
        Stack<string> stack = new Stack<string>();
        List<string> list = new List<string>();
        InputStack(stack);
        InverterStack(stack, list);
    }
    public static void InputStack(Stack<string> stack)
    {
        while (true)
        {
            Console.WriteLine("Digite o item: ");
            string item = Console.ReadLine().ToUpper();

            if (item == "SAIR")
            {
                break;
            }
            stack.Push(item);
        }
    }
    public static void InverterStack(Stack<string> stack, List<string> list)
    {
        while (stack.Count > 0)
        {
            list.Add(stack.Pop());
        }
        Console.WriteLine("\nItens invertidos: ");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}