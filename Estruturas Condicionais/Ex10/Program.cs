class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor para A (maior que zero): "); int a = int.Parse(Console.ReadLine()); if (a <= 0) { Console.WriteLine("Valor inválido! Digite novamente: "); a = int.Parse(Console.ReadLine()); }
        Console.WriteLine("Digite um valor para B (maior que zero): "); int b = int.Parse(Console.ReadLine()); if (b <= 0) { Console.WriteLine("Valor inválido! Digite novamente: "); b = int.Parse(Console.ReadLine()); }
        Console.WriteLine("Digite um valor para C (maior que zero): "); int c = int.Parse(Console.ReadLine()); if (c <= 0) { Console.WriteLine("Valor inválido! Digite novamente: "); c = int.Parse(Console.ReadLine()); }  
        int menor = Math.Min(a, Math.Min(b, c)); int maior = Math.Max(a, Math.Max(b, c)); Console.WriteLine("Menor x Maior = " + (menor * maior)); Console.WriteLine("Maior / Menor = " + (maior / menor));
    }
}