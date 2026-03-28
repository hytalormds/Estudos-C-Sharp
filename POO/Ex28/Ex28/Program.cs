class Program
{
    public static void Main()
    {
        while (true)
        {
            var dados = InputDados();

            // 🔄 Converte string em objeto (Factory)
            IPermissao permissao = CriarPermissao(dados.permissao);

            // 👤 Cria usuário com a permissão correta
            Usuario user = new Usuario(
                dados.nome,
                dados.email,
                dados.senha,
                permissao
            );

            // 🔥 Polimorfismo acontecendo aqui
            user.Permissao.TemPermissao();

            Console.WriteLine("\nDeseja continuar? (S/N)");
            string resp = Console.ReadLine().ToUpper();

            if (resp != "S")
                break;
        }
    }

    // 📥 Entrada de dados
    public static (string nome, string email, string senha, string permissao) InputDados()
    {
        Console.WriteLine("\nDigite o nome do usuário:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o email do usuário:");
        string email = Console.ReadLine();

        Console.WriteLine("Digite a senha do usuário:");
        string senha = Console.ReadLine();

        Console.WriteLine("Digite a permissão (ADMIN, LEITURA, ESCRITA):");
        string permissao = Console.ReadLine();

        return (nome, email, senha, permissao);
    }

    // 🏭 Factory simples (string → objeto)
    public static IPermissao CriarPermissao(string tipo)
    {
        switch (tipo.ToUpper())
        {
            case "ADMIN":
                return new PermissaoAdmin();
            case "LEITURA":
                return new PermissaoLeitura();
            case "ESCRITA":
                return new PermissaoEscrita();
            default:
                throw new Exception("Permissão inválida.");
        }
    }
}