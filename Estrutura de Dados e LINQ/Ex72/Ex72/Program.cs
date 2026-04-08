class Program
{
    public static void Main()
    {
        Stack<Acao> stack = new Stack<Acao>();
        InputAcao(stack);
        DisplayAcao(stack);
    }
    public static void InputAcao(Stack<Acao> stack)
    {
        while (true)
        {
            Console.Write("Digite a descrição da ação (ou 'sair' para encerrar): ");
            string descricao = Console.ReadLine().ToUpper();

            if (descricao == "SAIR")
            {
                break;
            }

            Acao acao = new Acao { Descricao = descricao };

            stack.Push(acao);
        }
    }
    public static void DisplayAcao(Stack<Acao> stack)
    {
        if (stack.Count > 0)
        {
            foreach (var acao in stack)
            {
                Console.WriteLine($"Ação: {acao.Descricao}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma ação foi registrada.");
        }
    }
}