using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Usuario usuario = InputUser();
            Livro livro = InputBook();

            if (!livro.Disponivel)
            {
                Console.WriteLine("Livro indisponível para empréstimo.");
                continue;
            }

            Emprestimo emprestimo = new Emprestimo();

            // 🔗 Ligando os objetos
            emprestimo.Usuario = usuario;
            emprestimo.Livro = livro;

            // 📅 Definindo datas
            emprestimo.DataPrevista = DateTime.Today.AddDays(7);

            Console.WriteLine("Digite a data de devolução (yyyy-MM-dd):");
            DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());

            emprestimo.DataDevolucaoReal = dataDevolucao;

            // 💰 Calculando multa
            double multa = emprestimo.CalcularMulta();

            Console.WriteLine($"Usuário: {usuario.Nome}");
            Console.WriteLine($"Livro: {livro.Titulo}");
            Console.WriteLine($"Data prevista: {emprestimo.DataPrevista:dd/MM/yyyy}");
            Console.WriteLine($"Data devolução: {emprestimo.DataDevolucaoReal:dd/MM/yyyy}");
            Console.WriteLine($"Multa: R$ {multa:F2}");

            Console.WriteLine("\nDeseja fazer outro empréstimo? (s/n)");
            string resp = Console.ReadLine().ToLower();

            if (resp != "s")
                break;
        }
    }

    public static Usuario InputUser()
    {
        Console.WriteLine("\nDigite o nome do usuário:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o ID do usuário:");
        int id = int.Parse(Console.ReadLine());

        return new Usuario { Nome = nome, Id = id };
    }

    public static Livro InputBook()
    {
        Console.WriteLine("\nDigite o título do livro:");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite o autor do livro:");
        string autor = Console.ReadLine();

        Console.WriteLine("O livro está disponível? (s/n):");
        bool disponivel = Console.ReadLine().ToLower() == "s";

        return new Livro { Titulo = titulo, Autor = autor, Disponivel = disponivel };
    }
}