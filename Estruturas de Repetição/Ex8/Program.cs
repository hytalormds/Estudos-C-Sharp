class Program
{
    public static void Main()
    {
        string op = "S";
        double media = 0, soma = 0;
        int qtd = 0;

        while (op.ToUpper() == "S")
        {
            Console.WriteLine("Digite a matrícula: ");
            string mat = Console.ReadLine();

            Console.WriteLine("Digite a nota dos alunos: ");
            int nota = int.Parse(Console.ReadLine());

            qtd += 1;
            soma += nota;

            Console.WriteLine("Deseja Continuar? [S/N]");
            op = Console.ReadLine();
        }
        if(qtd > 0)
        {
            media = soma / qtd;
            Console.WriteLine("A média das notas é: " + media);
        }
        else
        {
            Console.WriteLine("Nenhuma nota informada");
        }
    }
}