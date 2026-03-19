    class Program
    {
        public static void Main()
        {
            (string nome, int nota1, int nota2) dados = InputDados();
            Aluno aluno = new Aluno(dados.nome, dados.nota1, dados.nota2);

            double media = aluno.Media();
            bool aprovado = aluno.Aprovado();

            Console.WriteLine($"Aluno: {aluno.Nome}");
            Console.WriteLine($"Média: {media:F2}");

            if (aprovado)
                Console.WriteLine("Status: Aprovado");
            else
                Console.WriteLine("Status: Reprovado");
    }
    public static (string nome, int nota1, int nota2) InputDados()
    {
        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        int nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        int nota2 = int.Parse(Console.ReadLine());

        return (nome, nota1, nota2);
    }
}
