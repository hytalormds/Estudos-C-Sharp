class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha um personagem para atacar:");
            Console.WriteLine("1. Mago");
            Console.WriteLine("2. Guerreiro");
            Console.WriteLine("3. Arqueiro");
            Console.WriteLine("4. Sair");
            string escolha = Console.ReadLine();
            Personagem personagem;
            switch (escolha)
            {
                case "1":
                    personagem = new Mago();
                    break;
                case "2":
                    personagem = new Guerreiro();
                    break;
                case "3":
                    personagem = new Arqueiro();
                    break;
                case "4":
                    return; // Sai do programa
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
            }
            personagem.Atacar();
        }
    }
}