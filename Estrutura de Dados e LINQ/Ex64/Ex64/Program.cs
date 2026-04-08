class Program
{
    public static void Main()
    {
        Stack<string> pilha = new Stack<string>();
        InputPilha(pilha);
        CountPilha(pilha);
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
    public static void CountPilha(Stack<string> pilha)
    {
        Console.WriteLine($"Quantidade de Elementos: {pilha.Count()}");
    }
}