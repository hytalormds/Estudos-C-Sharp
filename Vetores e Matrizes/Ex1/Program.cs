class Program
{
    public static void Main()
    {
        Console.WriteLine("Quantos números você deseja digitar?");
        int tamanho = int.Parse(Console.ReadLine());

        int[] numeros = new int[tamanho];
        string op = "S";
        int contador = 0;

        while (op.ToUpper() == "S" && contador < tamanho)
        {
            Console.WriteLine("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            numeros[contador] = n;
            contador++;

            if (contador < tamanho)
            {
                Console.WriteLine("Deseja continuar? [S/N]");
                op = Console.ReadLine().ToUpper();
            }
            else
            {
                Console.WriteLine("O vetor já está cheio!");
            }
        }

        Console.WriteLine("Números digitados:");
        for (int i = tamanho; i < numeros.Length; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
