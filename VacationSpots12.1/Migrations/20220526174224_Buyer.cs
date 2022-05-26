using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationSpots12._1.Migrations
{
    public partial class Buyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(

                name: "Buyer",
                table: "Vacations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
