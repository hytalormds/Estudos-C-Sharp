class Pessoa{
    // Atributos

    public string Nome;
    public int Idade;

    // Métodos

    public void Apresentar()
    {
        Console.WriteLine($"Olá meu nome é {Nome}!");
    }

    public string Maioridade()
    {
        return Idade >= 18 ? "Maior de Idade" : "Menor de Idade";
    }
}
