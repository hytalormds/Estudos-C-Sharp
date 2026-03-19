class Program
{
    public static void Main()
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("Digite a opção: ");
        calc.op = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número: ");
        calc.n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        calc.n2 = double.Parse(Console.ReadLine());

        if (calc.op == 1)
        {
            double soma = calc.Soma(calc.n1, calc.n2);
            Console.WriteLine($"A soma é: {soma}");
        }
        else if (calc.op == 2)
        {
            double subtracao = calc.Subtracao(calc.n1, calc.n2);
            Console.WriteLine($"A subtração é: {subtracao}");
        }
        else if (calc.op == 3)
        {
            double multiplicacao = calc.Multiplicacao(calc.n1, calc.n2);
            Console.WriteLine($"A multiplicação é: {multiplicacao}");
        }
        else if (calc.op == 4)
        {
            double divisao = calc.Divisao(calc.n1, calc.n2);
            Console.WriteLine($"A divisão é: {divisao}");
        }
    }
}