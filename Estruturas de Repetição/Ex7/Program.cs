class Program
{
    public static void Main()
    {
        int qdd = 0, somaQdd = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Digite os números: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                qdd = n * n;
                somaQdd += qdd;
            }
        }
        Console.WriteLine("A soma do quadrado dos números ímpares são: " + somaQdd);
    }
}