class Program
{
    public static void Main()
    {
        Stack<int> pilha = new Stack<int>();
        InputPilha(pilha);
        RemovePilha(pilha);
    }
    public static void InputPilha(Stack<int> pilha)
    {
        while (true)
        {
            Console.WriteLine("Digite o número: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                break;
            }
            pilha.Push(num);
        }
    }
    public static void RemovePilha(Stack<int> pilha)
    {
        while (pilha.Count > 0)
        {
            Console.WriteLine($"Número Removido: {pilha.Pop()}");
        }
    }
}