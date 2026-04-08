class Program
{
    public static void Main()
    {
        Stack<string> pilha = new Stack<string>();
        InputPilha(pilha);
        Desfazer(pilha);
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
    public static void Desfazer(Stack<string> pilha)
    {
        if (pilha.Count > 0)
        {
            string acao = pilha.Pop();
            Console.WriteLine($"Ação Desfeita: {acao}");
        }
        else
        {
            Console.WriteLine("Não há páginas para voltar");
        }
    }
}