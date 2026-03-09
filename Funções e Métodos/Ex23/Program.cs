using System;

class Program
{
    public static void Main()
    {
        string password = InputPassword();
        CheckPassword(password);
    }

    public static string InputPassword()
    {
        Console.WriteLine("Digite a senha:");
        return Console.ReadLine();
    }

    public static void CheckPassword(string password)
    {
        bool hasLetter = false;
        bool hasNumber = false;

        foreach (char c in password)
        {
            if (char.IsLetter(c))
                hasLetter = true;

            if (char.IsDigit(c))
                hasNumber = true;
        }

        if (password.Length >= 8 && hasLetter && hasNumber)
        {
            Console.WriteLine("Senha válida");
        }
        else
        {
            Console.WriteLine("Senha inválida");
        }
    }
}