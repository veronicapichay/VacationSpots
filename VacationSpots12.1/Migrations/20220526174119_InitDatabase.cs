using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationSpots12._1.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Categories = table.Column<int>(type: "int", nullable: false),
                    Buyer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Backpacking" },
                    { 2, "Outback" },
                    { 3, "City" },
                    { 4, "Island" }
                });

            migrationBuilder.InsertData(
                table: "Vacations",
                columns: new[] { "Id", "Buyer", "Categories", "CategoriesCategoryId", "CategoryId", "Days", "Description", "ImageName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, 2, null, 3, 10, "Get lost in spices and enjoy the Morrocan vibe", "marrakech.jpg", "Steamy Nights in Marrakech", 10000.0 },
                    { 2, null, 1, null, 2, 7, "Get a front seat view watching Kangaroos on their natural habitat", "australia.jpg", "Australian Boxing Show", 12000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_CategoriesCategoryId",
                table: "Vacations",
                column: "CategoriesCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
