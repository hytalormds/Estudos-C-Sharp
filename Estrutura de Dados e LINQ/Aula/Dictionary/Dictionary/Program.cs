using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(10, "Carro");
        dict.Add(5, "Avião");
        dict.Add(0, "Navio");
        dict.Add(20, "Moto");

        //dict.Clear();

        dict.Remove(20);
        dict[10] = "Bicicleta";

        Console.WriteLine("Tamanho do dicionário: " + dict.Count);
        string valor = "Bicicleta";

        if (dict.ContainsValue(valor))
        {
            Console.WriteLine($"Valor {valor} existe");
        }
        else
        {
            Console.WriteLine($"Valor {valor} não existe");
        }

        int chave = 10;
        if (dict.ContainsKey(chave))
        {
            Console.WriteLine($"Chave {chave} existe");
        }
        else
        {
            Console.WriteLine($"Chave {chave} não existe");
        }

        Dictionary<int, String>.ValueCollection valores = dict.Values;

        foreach (string v in valores)
        {
            Console.WriteLine(v);
        }
    }
}