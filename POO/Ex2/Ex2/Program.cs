class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();

        p1.Nome = "Notebook";
        p1.Preco = 2500.00;
        p1.Quantidade = 10;

        p1.ValorTotal();
        p1.Exibir();
    }
}