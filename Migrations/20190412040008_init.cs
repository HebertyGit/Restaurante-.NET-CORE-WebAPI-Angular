using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RestauranteWeb.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prato",
                columns: table => new
                {
                    PratoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisponibilidadePrato = table.Column<int>(type: "INTEGER", nullable: false),
                    NomePrato = table.Column<string>(type: "TEXT", nullable: true),
                    RestauranteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorPrato = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prato", x => x.PratoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prato");
        }
    }
}
