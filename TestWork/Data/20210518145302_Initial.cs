using Microsoft.EntityFrameworkCore.Migrations;

namespace Hogwarts.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Identificacion = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Edad = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    Escuela = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "Id", "Apellido", "Edad", "Escuela", "Identificacion", "Nombre" },
                values: new object[] { 1, "Lopez", "29", "Gryffindor", "20614527", "David" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
