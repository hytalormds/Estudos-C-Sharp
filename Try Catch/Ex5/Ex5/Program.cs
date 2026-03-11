class Program
{
    public static void Main()
    {
        (int number1, int number2, string op) dados = InputNumbers();
        Calculadora(dados.number1, dados.number2, dados.op);
    }
    public static (int number1, int number2, string op) InputNumbers()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite o 1° número: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2° número: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a operação (+, -, *, /): ");
                string op = Console.ReadLine();

                return (number1, number2, op);

            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero. Por favor, tente novamente.");
            }
        }
    }

    public static void Calculadora(int number1, int number2, string op)
    {
        switch (op)
        {
            case "+":
                Console.WriteLine($"Resultado: {number1 + number2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {number1 - number2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {number1 * number2}");
                break;
            case "/":
                try
                {
                    Console.WriteLine($"Resultado: {number1 / number2}");
                    break;
                }catch (DivideByZeroException)
                {
                    Console.WriteLine("Não é possível dividir por zero. Por favor, tente novamente.");
                    break;
                }
            default:
                Console.WriteLine("Operação inválida. Por favor, use +, -, *, ou /.");
                break;
        }
    }
}