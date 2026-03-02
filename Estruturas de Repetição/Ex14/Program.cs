class Program
{
    public static void Main()
    {
        string op = "N";

        while (op != "S")
        {
            Console.WriteLine("Digite um número");
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("Número PAR");
            }
            else
            {
                Console.WriteLine("Número ÍMPAR");
            }
            if(n < 0)
            {
                Console.WriteLine("Número NEGATIVO");
            }
            else
            {
                Console.WriteLine("Número POSITIVO");
            }
            Console.WriteLine("Deseja Continuar? [S/N]");
            op = Console.ReadLine().ToUpper();
        }
    }
}