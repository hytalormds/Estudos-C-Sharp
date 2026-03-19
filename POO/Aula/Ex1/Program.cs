class Program
{
    public static void Main()
    {
        Pessoa obj1 = new Pessoa();
        obj1.Nome = "Maria";
        //obj1.Apresentar();

        Pessoa obj2 = new();
        obj2.Nome = "João";
        //obj2.Apresentar();

        Pessoa obj3 = new() {Nome = "Pedro", Idade = 25};

        string retorno = obj3.Maioridade();
        Console.WriteLine(retorno);
    }
}