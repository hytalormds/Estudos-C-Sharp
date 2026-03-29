using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        List<string> Names = new List<string>();
        InputNames(Names);
        VerificationName(Names);
    }
    public static void InputNames(List<string> Names)
    {
        while (true)
        {
            Console.WriteLine("Digite os nomes: ");
            string name = Console.ReadLine().ToUpper();
            if (name == "SAIR")
            {
                break;
            }
            Names.Add(name);
        }
    }
    public static void VerificationName(List<string> Names)
    {
        if (Names.Contains("JOÃO"))
        {
            Console.WriteLine("O nome João está presente na lista.");

        }
        else
        {
            Console.WriteLine("O nome João não está presente na lista.");
        }
    }
}