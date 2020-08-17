using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleControl.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Detalhe = table.Column<string>(nullable: true),
                    Marcaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca_Marcaid",
                        column: x => x.Marcaid,
                        principalTable: "Marca",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Modeloid = table.Column<int>(nullable: true),
                    Marcaid = table.Column<int>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Cor = table.Column<string>(nullable: true),
                    Combustivel = table.Column<string>(nullable: true),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Anuncio_Marca_Marcaid",
                        column: x => x.Marcaid,
                        principalTable: "Marca",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anuncio_Modelo_Modeloid",
                        column: x => x.Modeloid,
                        principalTable: "Modelo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_Marcaid",
                table: "Anuncio",
                column: "Marcaid");

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_Modeloid",
                table: "Anuncio",
                column: "Modeloid");

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_Marcaid",
                table: "Modelo",
                column: "Marcaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "Modelo");
        }
    }
}
