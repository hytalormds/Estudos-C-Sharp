class Program
{
    public static void Main()
    {
        int number = InputNumber();
        bool primo = VerificaPrimo(number);

        if (primo)
        {
            Console.WriteLine($"{number} é primo");
        }
        else
        {
            Console.WriteLine($"{number} não é primo");
        }
    }

    public static int InputNumber()
    {
        Console.WriteLine("Digite o número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static bool VerificaPrimo(int number)
    {
        if (number <= 1) return false; 

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false; 
        }
        return true; 
    }
}