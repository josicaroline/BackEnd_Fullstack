using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Ef_DTO.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataLocacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarroModel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.CODIGO);
                    table.ForeignKey(
                        name: "FK_Marcas_Carros_CarroModel",
                        column: x => x.CarroModel,
                        principalTable: "Carros",
                        principalColumn: "CODIGO");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_CarroModel",
                table: "Marcas",
                column: "CarroModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Carros");
        }
    }
}
