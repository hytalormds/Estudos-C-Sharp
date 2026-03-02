class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a nota N1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota N2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota N3: ");
        int n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota N4: ");
        int n4 = int.Parse(Console.ReadLine());

        float media, novaMedia;

        media = (n1 + n2 + n3 + n4) / 4;

        if (media < 7)
        {
            Console.WriteLine("Digite a nota de recuperação: ");
            int recp = int.Parse(Console.ReadLine());
            novaMedia = (recp + media) / 2;
            if (novaMedia >= 7)
            {
                Console.WriteLine("Aluno aprovado na recuperação:" + novaMedia);
            }
            else
            {
                Console.WriteLine("Aluno reprovado:" + novaMedia);
            }
        }
        else
        {
            Console.WriteLine("Aluno Aprovado:" + media);
        }
    }
}