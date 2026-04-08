using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine().ToLower();

        bool resultado = EhPalindromo(palavra);

        if (resultado)
            Console.WriteLine("É palíndromo!");
        else
            Console.WriteLine("Não é palíndromo.");
    }

    public static bool EhPalindromo(string palavra)
    {
        Stack<char> pilha = new Stack<char>();

        // 1. Empilhar letras
        foreach (char c in palavra)
        {
            pilha.Push(c);
        }

        // 2. Montar palavra invertida
        string invertida = "";

        while (pilha.Count > 0)
        {
            invertida += pilha.Pop();
        }

        // 3. Comparar
        return palavra == invertida;
    }
}