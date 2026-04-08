class Program
{
    public static void Main()
    {
        Stack<string> stack = new Stack<string>();
        StackOperacao(stack);
    }
    public static void StackOperacao(Stack<string> stack)
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
            Console.WriteLine("Item adicionado: " + stack.Peek());
        }
    }
}