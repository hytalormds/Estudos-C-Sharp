class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a quantidade de números de cada vetor: ");
        int qtd = int.Parse(Console.ReadLine());

        int[] x = InputNumbers(qtd);
        int[] y = InputNumbers(qtd);

        SomaVetores(x, y, qtd);
    }
    public static int[] InputNumbers(int qtd)
    {
        int[] vetor = new int[qtd];

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Digite os valores para a posição: {i + 1}");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        return vetor;
    }
    public static void SomaVetores(int[] x, int[] y, int qtd)
    {
        int produto = 0;

        for (int i = 0; i < qtd; i++)
        {
            produto += x[i] * y[i];
        }
        Console.WriteLine($"Produto Escalar: {produto}");
    }
}