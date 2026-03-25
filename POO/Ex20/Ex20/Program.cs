class Program
{
    public static void Main()
    {
        Agenda agenda = new Agenda();
        string nome = InputName();
        Contato contato = new Contato { Nome = nome };
        agenda.AdicionarContato(contato);
        agenda.ExibirContatos();
    }
    public static string InputName()
    {
        Console.WriteLine("Digite o nome do contato:");
        string nome = Console.ReadLine();
        return nome;
    }
}