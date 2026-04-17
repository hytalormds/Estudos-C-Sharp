using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias (Nome, ImageUrl) VALUES ('Bebida', 'bebidas.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImageUrl) VALUES ('Lanches', 'lanche.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImageUrl) VALUES ('Sobremesas', 'sobremesa.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categorias");
        }
    }
}
