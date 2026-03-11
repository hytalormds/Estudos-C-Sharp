using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        int number = InputNumber();
        ExibirNumero(number);
    }
    public static int InputNumber()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite um número: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception();
                }
                return number;
            }
            catch (Exception e)
            {
                Console.WriteLine("Número não pode ser negativo");
            }
        }
    }
    
        public static void ExibirNumero(int number)
        {
            Console.WriteLine($"O número digitado foi: {number}");
    }
}
