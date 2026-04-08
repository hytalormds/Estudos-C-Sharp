using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("Primeiro");
        stack.Push("Segundo");
        stack.Push("Terceiro");

        Console.WriteLine("Página atual: " + stack.Peek());
        stack.Pop();
        Console.WriteLine("Página atual: " + stack.Peek());
    }
}