class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o tempo gasto da viagem: ");
        float tpGastoViagem = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade média: ");
        float vlMedia = float.Parse(Console.ReadLine());

        Console.WriteLine($"Velocidade Média: {vlMedia}");
        Console.WriteLine($"Tempo Gasto: {tpGastoViagem}");
        Console.WriteLine($"Distância Percorrida: {tpGastoViagem*vlMedia}");
        Console.WriteLine($"Litros Usados: {(tpGastoViagem*vlMedia)/12}");
    }
}