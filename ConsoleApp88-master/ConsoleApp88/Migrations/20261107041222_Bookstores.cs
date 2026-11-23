using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp88.Migrations
{
    /// <inheritdoc />
    public partial class Bookstores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authorss",
                columns: table => new
                {
                    fristName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailaddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortbiograohy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorss", x => x.fristName);
                });

            migrationBuilder.CreateTable(
                name: "Bookss",
                columns: table => new
                {
                    title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    pagegNumber = table.Column<int>(type: "int", nullable: false),
                    years = table.Column<int>(type: "int", nullable: false),
                    currentStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookss", x => x.title);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    theconditionactiveorNonactive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "authorss");

            migrationBuilder.DropTable(
                name: "Bookss");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}
