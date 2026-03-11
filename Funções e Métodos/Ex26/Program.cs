class Program
{
    public static void Main()
    {
        int x = InputNumber();
        int y = InputNumber();
        VerificaQuadrante(x, y);
    }
    public static int InputNumber()
    {
        Console.WriteLine("Digite os valores: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    public static void VerificaQuadrante(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Quadrante 1");
        }else if (x < 0 && y > 0)
        {
            Console.WriteLine("Quadrante 2");
        }else if (x < 0 && y < 0)
        {
            Console.WriteLine("Quadrante 3");
        }else if (x > 0 && y < 0)
        {
            Console.WriteLine("Quadrante 4");
        }
        else
        {
            Console.WriteLine("Ponto Sobre Os Eixos");
        }
    }
}