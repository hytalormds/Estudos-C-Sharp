class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor de 0 a 9: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 9)
        {
            Console.WriteLine("Valor Válido");
        }
        else
        {
            Console.WriteLine("Valor Inválido");
        }
    }
}