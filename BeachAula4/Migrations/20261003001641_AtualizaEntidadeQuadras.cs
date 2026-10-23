using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeachAula4.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaEntidadeQuadras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativa",
                table: "Quadras",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorHora",
                table: "Quadras",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativa",
                table: "Quadras");

            migrationBuilder.DropColumn(
                name: "ValorHora",
                table: "Quadras");
        }
    }
}
