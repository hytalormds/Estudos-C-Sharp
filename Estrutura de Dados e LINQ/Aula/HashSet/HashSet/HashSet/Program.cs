using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Program
{
    public static void Main()
    {
        var timeSp = new HashSet<string> { "Santos", "Palmeiras", "São Paulo"};
        var timeRj = new HashSet<string> { "Vasco", "Flamengo", "Fluminense"};
        var timeBa = new HashSet<string> { "Bahia", "Vitória", "Juazeiro" };

        var timesMundiais = new HashSet<string> { "Santos", "Palmeiras", "São Paulo", "Flamengo"};

        //if (!timeSp.Contains("Corinthians"))
        //{
        //    timeSp.Add("Corinthians");
        //    timeSp.Add("Santos");
        //}

        if (timeSp.IsSubsetOf(timesMundiais)){
            Console.WriteLine("Times de SP é um subconjunto de mundiais");
        }

        if (timeRj.Overlaps(timesMundiais))
        {
            Console.WriteLine("Pelo menos um time do RJ tem mundial");
        }

        if (!timeSp.SetEquals(timeRj))
        {
            Console.WriteLine("Times de SP e RJ não contém os mesmos elementos");
        }

        //var resultado = timeBa.Remove("Juazeiro");

        Console.WriteLine("\n Juntando SP, RJ e BA");
        timeSp.UnionWith(timeRj);
        timeSp.ExceptWith(timeBa);

        foreach (var time in timeSp)
        {
            Console.WriteLine(time);
        }
    }
}