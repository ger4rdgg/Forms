using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forms.Migrations
{
    public partial class InitialDatabaseSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pregunta1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pregunta2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pregunta3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    respuesta1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    respuesta2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    respuesta3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form");
        }
    }
}
