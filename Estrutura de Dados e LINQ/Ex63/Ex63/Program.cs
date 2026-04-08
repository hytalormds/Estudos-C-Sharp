class Program
{
    public static void Main()
    {
        Stack<string> pilha = new Stack<string>();
        InputPilha(pilha);
        DisplayPilha(pilha);
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
    public static void DisplayPilha(Stack<string> pilha)
    {
        string itemRemover = pilha.Peek();
        Console.WriteLine($"Último Item: {itemRemover}");
    }
}