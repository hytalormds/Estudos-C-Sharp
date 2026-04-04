using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();
        InputNumbers(numbers);
        ExibirNumeros(numbers);
    }
    public static void InputNumbers(HashSet<int> numbers)
    {
        while (true)
        {
            Console.WriteLine("Digite o número: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            numbers.Add(number);
        }
    }

    public static void ExibirNumeros(HashSet<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}