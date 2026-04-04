class Produto
{
    public string Nome { get; set; }
    public string CodigoBarras { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Produto outro)
        {
            return Nome == outro.Nome &&
                CodigoBarras == outro.CodigoBarras;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, CodigoBarras);
    }
}