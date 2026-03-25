class Program
{
    public static void Main()
    {
        Usuarios userAdmin = new Admin();
        Usuarios userComum = new UsuarioComum();

        bool admin = userAdmin.PodeExcluir();
        bool comum = userComum.PodeExcluir();

        Console.WriteLine("O Admin pode excluir? " + admin);
        Console.WriteLine("O Usuário Comum pode excluir? " + comum);
    }
}