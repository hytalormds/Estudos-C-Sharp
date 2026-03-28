class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Digite a mensagem de log:");
            string mensagem = Console.ReadLine();
            Console.WriteLine("Escolha o tipo de log:");
            Console.WriteLine("1 - LogConsole");
            Console.WriteLine("2 - LogArquivo");
            Console.WriteLine("3 - LogBanco");
            int escolha = int.Parse(Console.ReadLine());
            ILogger logger;
            switch (escolha)
            {
                case 1:
                    logger = new LogConsole();
                    break;
                case 2:
                    logger = new LogArquivo();
                    break;
                case 3:
                    logger = new LogBanco();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Usando LogConsole por padrão.");
                    logger = new LogConsole();
                    break;
            }
            logger.Registrar(mensagem);
        }
    }
}