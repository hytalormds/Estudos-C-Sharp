class Program
{
    public static void Main()
    {
        Stack<string> pilha = new Stack<string>();
        InputPilha(pilha);
        Historico(pilha);
    }
    public static void InputPilha(Stack<string> pilha)
    {
        while (true)
        {
            Console.Write("Digite uma página: ");
            string pagina = Console.ReadLine().ToUpper();

            if (pagina == "SAIR")
            {
                break;
            }
            pilha.Push(pagina);
        }
    }
    public static void Historico(Stack<string> pilha)
    {
        if (pilha.Count > 0)
        {
            string removida = pilha.Pop();
            Console.WriteLine($"Saindo da página: {removida}");
            if (pilha.Count > 0)
            {
                Console.WriteLine($"Você está em: {pilha.Peek()}");
            }
            else
            {
                Console.WriteLine("Você não está em nenhuma página");
            }
        }
        else
        {
            Console.WriteLine("Não há páginas para voltar");
        }
    }
}