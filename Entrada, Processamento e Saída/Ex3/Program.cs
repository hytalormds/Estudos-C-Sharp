class Program
{
    public static void Main()
    {
        Console.WriteLine("[Comissão de Peças]");

        Console.WriteLine("Digite o identificador do vendedor: ");
        string id = Console.ReadLine();

        Console.WriteLine("Digite o código da peça: ");
        string cdPeca = Console.ReadLine();

        Console.WriteLine("Digite o preço unitário: ");
        float precoUnitario = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade vendida: ");
        int qtdVendida = int.Parse(Console.ReadLine());

        float totVendido;
        float comissao;

        totVendido = precoUnitario * qtdVendida;
        comissao = totVendido * 0.5f;

        Console.WriteLine($"Total Vendido: {totVendido :F2}");
        Console.WriteLine($"Comissão Total: {comissao :F2}");
    }
}