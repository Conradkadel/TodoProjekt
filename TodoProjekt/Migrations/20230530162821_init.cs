using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoProjekt.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EinzelAufgabe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    Prozentsatz = table.Column<double>(type: "float", nullable: true),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErstellDatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BearbeitungsDatum = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EinzelAufgabe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnterAufgabe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checked = table.Column<bool>(type: "bit", nullable: false),
                    EinzelAufgabenId = table.Column<int>(type: "int", nullable: false),
                    ErstellDatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BearbeitungsDatum = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnterAufgabe", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EinzelAufgabe");

            migrationBuilder.DropTable(
                name: "UnterAufgabe");
        }
    }
}
