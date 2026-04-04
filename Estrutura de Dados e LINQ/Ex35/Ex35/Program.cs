class Program
{
    public static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        InputNomes(set);
        RemoverNomes(set);
    }
    public static void InputNomes(HashSet<string> set)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine().ToUpper();

            if (string.IsNullOrEmpty(nome))
            {
                break;
            }
            set.Add(nome);
        }
    }
    public static void RemoverNomes(HashSet<string> set)
    {
        while (true)
        {
            Console.WriteLine("Digite o nome a ser removido: ");
            string nomeRemover = Console.ReadLine().ToUpper();

            if (set.Contains(nomeRemover))
            {
                set.Remove(nomeRemover);
            }

            if (string.IsNullOrEmpty(nomeRemover))
            {
                break;
            }
            foreach (string nome in set)
            {
                Console.WriteLine(nome);
            }
        }
    }
}