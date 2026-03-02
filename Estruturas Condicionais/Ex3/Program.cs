class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor N1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor N2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor N3: ");
        int n3 = int.Parse(Console.ReadLine());

        if (n1 >= n2 && n1 >= n3) { 
            if (n2 >= n3) Console.WriteLine($"{n1}, {n2}, {n3}"); 
            
            else Console.WriteLine($"{n1}, {n3}, {n2}"); } else if (n2 >= n1 && n2 >= n3) { if (n1 >= n3) Console.WriteLine($"{n2}, {n1}, {n3}"); else Console.WriteLine($"{n2}, {n3}, {n1}"); } else { if (n1 >= n2) Console.WriteLine($"{n3}, {n1}, {n2}"); else Console.WriteLine($"{n3}, {n2}, {n1}"); }
    }
}