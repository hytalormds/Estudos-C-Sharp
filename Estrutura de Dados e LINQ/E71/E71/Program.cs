using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Stack<string> feitas = new Stack<string>();
        Stack<string> desfeitas = new Stack<string>();

        while (true)
        {
            Console.WriteLine("\n1 - Fazer ação");
            Console.WriteLine("2 - Undo");
            Console.WriteLine("3 - Redo");
            Console.WriteLine("4 - Ver estado");
            Console.WriteLine("5 - Sair");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Digite a ação: ");
                    string acao = Console.ReadLine();

                    feitas.Push(acao);
                    desfeitas.Clear(); // regra importante

                    break;

                case 2:
                    if (feitas.Count > 0)
                    {
                        var undo = feitas.Pop();
                        desfeitas.Push(undo);
                        Console.WriteLine($"Desfeito: {undo}");
                    }
                    else
                    {
                        Console.WriteLine("Nada para desfazer.");
                    }
                    break;

                case 3:
                    if (desfeitas.Count > 0)
                    {
                        var redo = desfeitas.Pop();
                        feitas.Push(redo);
                        Console.WriteLine($"Refazendo: {redo}");
                    }
                    else
                    {
                        Console.WriteLine("Nada para refazer.");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nFeitas:");
                    foreach (var f in feitas)
                        Console.WriteLine(f);

                    Console.WriteLine("\nDesfeitas:");
                    foreach (var d in desfeitas)
                        Console.WriteLine(d);
                    break;

                case 5:
                    return;
            }
        }
    }
}