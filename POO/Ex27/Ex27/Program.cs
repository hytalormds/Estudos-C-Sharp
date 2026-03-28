class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha o formato do relatório:");
            Console.WriteLine("1 - PDF");
            Console.WriteLine("2 - Excel");
            Console.WriteLine("3 - CSV");
            Console.WriteLine("0 - Sair");
            string escolha = Console.ReadLine();
            IRelatorio relatorio;
            switch (escolha)
            {
                case "1":
                    relatorio = new RelatorioPDF();
                    Console.WriteLine(relatorio);
                    break;
                case "2":
                    relatorio = new RelatorioExcel();
                    Console.WriteLine(relatorio);
                    break;
                case "3":
                    relatorio = new RelatorioCSV();
                    Console.WriteLine(relatorio);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
            }
            relatorio.Gerar();
        }
    }
}