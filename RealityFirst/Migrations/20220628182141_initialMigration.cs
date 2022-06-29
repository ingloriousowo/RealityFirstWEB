using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealityFirst.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eventos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    fotoURL = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 500, nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Lugar = table.Column<string>(maxLength: 100, nullable: false),
                    Artista = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eventos");
        }
    }
}
