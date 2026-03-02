class Program
{
    public static void Main()
    {
        string op = "S";

        while (op.ToUpper() == "S")
        {
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 5 && idade < 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (idade > 8 && idade < 11)
            {
                Console.WriteLine("Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }else if(idade > 14 && idade < 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else
            {
                Console.WriteLine("Adultos");
            }
            Console.WriteLine("Deseja Continuar? [S/N]");
            op = Console.ReadLine().ToUpper();
        }
    }
}