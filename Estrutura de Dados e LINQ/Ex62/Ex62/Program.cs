class Program
{
    public static void Main()
    {
        Stack<string> pilha = new Stack<string>();
        InputPilha(pilha);
        RemovePilha(pilha);
    }
    public static void InputPilha(Stack<string> pilha)
    {
        while (true)
        {
            Console.Write("Digite um item: ");
            string item = Console.ReadLine().ToUpper();

            if (item == "SAIR")
            {
                break;
            }
            pilha.Push(item);
        }
    }
    public static void RemovePilha(Stack<string> pilha)
    {
        string itemRemovido = pilha.Pop();
        Console.WriteLine($"Item removido: {itemRemovido}");
    }
}