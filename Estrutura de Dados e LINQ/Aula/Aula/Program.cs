using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Gol");
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Gol");

        //carros2.AddRange(carros);

        //carros2.Clear();

        if (carros.Contains("Gol")) { 
            Console.WriteLine("O carro Gol está na lista");
        }
        else
        {
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2, 2);

        carros.Insert(1, "Civic");

        int posCar = carros.LastIndexOf("Gol");

        foreach (string item in carros)
        {
            Console.WriteLine(item);
        }

        string c = "HRV";
        int pos = 0;
        pos= carros.IndexOf(c);
        Console.WriteLine($"O carro está na posição {pos}");
        Console.WriteLine($"O última posição de Gol está em {posCar}");
    }
}