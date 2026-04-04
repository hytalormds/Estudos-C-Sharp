class Program
{
    public static void Main()
    {
        HashSet<string> nomes = new HashSet<string>();
        InputNomes(nomes);
        BuscarNomes(nomes);
    }
    public static void InputNomes(HashSet<string> nomes)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(nome))
            {
                break;
            }
            nomes.Add(nome);
        }
    }
    public static void BuscarNomes(HashSet<string> nomes)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome a ser buscado: ");
            string nomeBusca = Console.ReadLine().ToUpper();

            if (nomes.Contains(nomeBusca))
            {
                Console.WriteLine($"O nome se encontra no conjunto");
            }
            else
            {
                Console.WriteLine($"O nome não se encontra no conjunto");
            }

            if (string.IsNullOrEmpty(nomeBusca))
            {
                break;
            }
        }
    }
}