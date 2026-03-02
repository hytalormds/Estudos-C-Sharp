class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor para A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para C: ");
        int c = int.Parse(Console.ReadLine());

        if (a + b > c || b + c > a || c + a > b)
        {
            if (a == b ||  b == c)
            {
                Console.WriteLine("Triângulo Equilátero");
            }else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Não é um triângulo");
        }
    }
}