class Pedido
{
    public List<ItemPedido> Itens = new List<ItemPedido>();

    public double CalcularTotal()
    {
        double total = 0;

        foreach (var item in Itens)
        {
            total += item.Preco * item.Quantidade;
        }
        if (total > 500)
        {
            total *= 0.9;
        }
        return total;
    }
}