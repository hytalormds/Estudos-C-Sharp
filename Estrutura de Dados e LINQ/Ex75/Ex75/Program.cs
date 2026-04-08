using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Stack<string> historico = new Stack<string>();

        while (true)
        {
            Console.WriteLine("\n1 - Adicionar ação");
            Console.WriteLine("2 - Desfazer ação");
            Console.WriteLine("3 - Ver histórico");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarAcao(historico);
                    break;

                case 2:
                    DesfazerAcao(historico);
                    break;

                case 3:
                    VerHistorico(historico);
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    public static void AdicionarAcao(Stack<string> historico)
    {
        Console.Write("Digite a ação: ");
        string acao = Console.ReadLine();

        historico.Push(acao);
        Console.WriteLine("Ação adicionada.");
    }

    public static void DesfazerAcao(Stack<string> historico)
    {
        if (historico.Count > 0)
        {
            string removida = historico.Pop();
            Console.WriteLine($"Ação desfeita: {removida}");
        }
        else
        {
            Console.WriteLine("Nenhuma ação para desfazer.");
        }
    }

    public static void VerHistorico(Stack<string> historico)
    {
        if (historico.Count == 0)
        {
            Console.WriteLine("Histórico vazio.");
            return;
        }

        Console.WriteLine("\nHistórico:");

        foreach (var acao in historico)
        {
            Console.WriteLine(acao);
        }

        Console.WriteLine($"\nTopo (ação atual): {historico.Peek()}");
    }
}