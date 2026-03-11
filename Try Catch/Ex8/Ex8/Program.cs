class Program
{
    public static void Main()
    {
        (string login, string password) dados = InputValues();
        Exibir(dados.login, dados.password);
    }
    public static (string login, string password) InputValues()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite o login: ");
                string login = Console.ReadLine();

                Console.Write("Digite a senha: ");
                string password = Console.ReadLine();

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                {
                    throw new Exception();
                }
                return (login, password);
            }
            catch (Exception)
            {
                Console.WriteLine("Login e senha não podem ser vazios. Tente novamente.");
            }
        }
    }

    public static void Exibir(string login, string password)
    {
        Console.WriteLine($"Login: {login}");
        Console.WriteLine($"Senha: {password}");
    }
}