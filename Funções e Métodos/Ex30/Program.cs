class Program
{
    public static void Main()
    {
        (int[] numbers, int op) dados = InputDados();
        CarregarVetor(dados.numbers);
        ListarVetor(dados.numbers);
        Par(dados.numbers);
        Impar(dados.numbers);
        QtdPar(dados.numbers);
        QtdImpar(dados.numbers);
        Opcao(dados.op);
    }
    public static (int[] numbers, int op) InputDados()
    {
        Console.WriteLine("Digite a quantidade de números: ");
        int qtd = int.Parse(Console.ReadLine());

        int[] numbers = new int[qtd];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Digite os números: ");
            numbers[i] = int.Parse (Console.ReadLine());
        }
        return numbers;
    }
    public static 
}