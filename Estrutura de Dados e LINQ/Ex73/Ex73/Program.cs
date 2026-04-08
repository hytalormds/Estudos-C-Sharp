using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Stack<string> historico = new Stack<string>();

        while (true)
        {
            Console.Write("Digite uma ação: ");
            string acao = Console.ReadLine();

            if (acao.ToUpper() == "SAIR")
                break;

            historico.Push(acao);

            if (historico.Count > 5)
            {
                RemoverMaisAntigo(historico);
            }

            Exibir(historico);
        }
    }

    public static void RemoverMaisAntigo(Stack<string> historico)
    {
        Stack<string> auxiliar = new Stack<string>();

        while (historico.Count > 0)
        {
            auxiliar.Push(historico.Pop());
        }

        string removido = auxiliar.Pop();
        Console.WriteLine($"Removendo mais antigo: {removido}");

        while (auxiliar.Count > 0)
        {
            historico.Push(auxiliar.Pop());
        }
    }

    public static void Exibir(Stack<string> historico)
    {
        Console.WriteLine("\nHistórico atual:");
        foreach (var item in historico)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}