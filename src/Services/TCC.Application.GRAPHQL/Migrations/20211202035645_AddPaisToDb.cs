using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCC.Application.GRAPHQL.Migrations
{
    public partial class AddPaisToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gentilico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePaisInternacional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
