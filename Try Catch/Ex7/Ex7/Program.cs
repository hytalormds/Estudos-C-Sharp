class Program
{
    public static void Main()
    {
        int number = InputNumber();
        RaizQuadrada(number);
    }
    public static int InputNumber()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite um número: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception();
                }
                return number;
            }catch (FormatException)
            {
                Console.WriteLine("Valor inválido. Digite um número inteiro.");

            }
            catch (Exception)
            {
                Console.WriteLine("Valor inválido. Digite um número inteiro positivo.");
        }
    }
}

public static void RaizQuadrada(int number)
    {
        double raiz = Math.Sqrt(number);
        Console.WriteLine($"A raiz quadrada de {number} é: {raiz}");
    }
}