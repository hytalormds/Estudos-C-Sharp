class Program
{
    public static void Main()
    {
        IFrete freteNormal = new FreteNormal();
        IFrete freteExpresso = new FreteExpresso();

        while (true)
        {
            var dados = InputDados();

            Console.WriteLine("Escolha a opção de frete:");
            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "NORMAL")
            {
                double valorNormal = freteNormal.CalcularFrete(dados.valor, dados.peso);
                Console.WriteLine("Valor do frete normal: " + valorNormal);
            }
            else if (opcao == "EXPRESSO") {
                double valorExpresso = freteExpresso.CalcularFrete(dados.valor, dados.peso);
                Console.WriteLine("Valor do frete expresso: " + valorExpresso);
            }

            Console.WriteLine("Deseja calcular o frete para outro produto?");
            string cont = Console.ReadLine().ToUpper();

            if (cont != "S") {
                break;
            }
        }
    }
    public static (double valor, double peso) InputDados()
    {
        Console.WriteLine("Digite o valor do produto:");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o peso do produto:");
        double peso = Convert.ToDouble(Console.ReadLine());

        return (valor, peso);
    }
}