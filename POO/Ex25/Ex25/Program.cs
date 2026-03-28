using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            var dados = InputDados();

            Console.WriteLine("Escolha o tipo de conta (CORRENTE / POUPANCA):");
            string opcao = Console.ReadLine().ToUpper();

            Conta conta;

            if (opcao == "CORRENTE")
            {
                conta = new ContaCorrente { Taxa = 5 };
            }
            else if (opcao == "POUPANCA")
            {
                conta = new ContaPoupanca { Rendimento = 0.05 };
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            // 🔗 Atribuindo dados
            conta.NumeroConta = dados.numeroconta;
            conta.Titular = dados.titular;

            // 💰 Depósito
            Console.WriteLine("Digite o valor para depósito:");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Depositar(valorDeposito);

            // 💸 Saque
            Console.WriteLine("Digite o valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Sacar(valorSaque);

            // 💰 Rendimento (apenas poupança)
            if (conta is ContaPoupanca poupanca)
            {
                poupanca.AplicarRendimento();
            }

            // 📊 Resultado final
            Console.WriteLine($"\nTitular: {conta.Titular}");
            Console.WriteLine($"Conta: {conta.NumeroConta}");
            Console.WriteLine($"Saldo final: R$ {conta.Saldo:F2}");

            Console.WriteLine("\nDeseja continuar? (S/N)");
            string resp = Console.ReadLine().ToUpper();

            if (resp != "S")
                break;
        }
    }

    public static (int numeroconta, string titular) InputDados()
    {
        Console.WriteLine("\nDigite o número da conta:");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do titular:");
        string titular = Console.ReadLine();

        return (numeroConta, titular);
    }
}