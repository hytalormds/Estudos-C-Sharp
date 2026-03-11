class Program
{
    public static void Main()
    {
        int age = InputAge();
        ExibirIdade(age);
    }

    public static int InputAge()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite o valor: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 0)
                {
                    throw new Exception();
                }

                return age;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite números.");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro: Digite número positivo.");
            }
        }
    }

    public static void ExibirIdade(int age)
    {
        Console.WriteLine($"Idade: {age}");
    }
}