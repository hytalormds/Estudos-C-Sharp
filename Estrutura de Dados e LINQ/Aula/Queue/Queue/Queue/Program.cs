using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        //string[] v = {"Carro", "Moto", "Navio"};
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro"); //Insere no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");


        if (veiculos.Contains("Avião"))
        {
            Console.WriteLine("Veiculo encontrado");
        }
        else
        {
            Console.WriteLine("Veiculo não encontrado");
        }

        //veiculos.Clear();

        //Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue());
        //Console.WriteLine("Primeiro Veiculo " + veiculos.Peek());
        //Console.WriteLine("Tamanho da fila: " + veiculos.Count());

        foreach (string veic in veiculos)
        {
            veic=veiculos.Dequeue();
            Console.WriteLine("VeiculoRemovido: " + veic);
        }
    }
}