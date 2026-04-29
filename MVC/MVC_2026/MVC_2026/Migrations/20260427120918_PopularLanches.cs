using Microsoft.EntityFrameworkCore.Migrations;
using MVC_2026.Models;

#nullable disable

namespace MVC_2026.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrguer com ovo frito, presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'cheesesalada1.jpg', 'cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
