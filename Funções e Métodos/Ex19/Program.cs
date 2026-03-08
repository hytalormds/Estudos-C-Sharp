class Program
{
    public static void Main()
    {
        int n = InputNumber();
        VerificaNum(n);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite o número: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static void VerificaNum(int number)
    {
        int soma = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                soma += i;
            }
        }
        if(soma == number)
        {
            Console.WriteLine("Número Perfeito");
        }
        else
        {
            Console.WriteLine("Número Imperfeito");
        }
    }
}