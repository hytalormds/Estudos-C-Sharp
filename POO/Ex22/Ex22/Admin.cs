class Admin : Usuarios
{
    public override bool PodeExcluir()
    {
       return true;
    }
}