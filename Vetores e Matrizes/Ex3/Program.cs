class Program
{
    public static void Main()
    {
        int[] vetor = InputNumbers();
        int x = InputNumber();
        Validacao(vetor, x);
    }
    public static int[] InputNumbers()
    {
        int[] vetor = new int[10];

        for(int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite os números: {i+1}");
            vetor[i] = int.Parse( Console.ReadLine() );
        }
        return vetor;
    }

    public static int InputNumber()
    {
        Console.WriteLine("Digite o valor: ");
        int x = int.Parse(Console.ReadLine());

        return x;
    }

    public static void Validacao(int[] vetor, int x)
    {
        int qtdMaior = 0, qtdMenor = 0, igualX = 0;

        for(int i = 0; i < vetor.Length; i++)
        {
            if(vetor[i] > x)
            {
                qtdMaior++;
            }
            if (vetor[i] < x)
            {
                qtdMenor++;
            }
            if (x == vetor[i])
            {
                igualX++;
            }
        }
        Console.WriteLine($"A quantidade de números maior que {x} é {qtdMaior}: ");
        Console.WriteLine($"A quantidade de números menor que {x} é {qtdMenor}: ");
        Console.WriteLine($"A quantidade de números igual {x} é {igualX}: ");
    }
}