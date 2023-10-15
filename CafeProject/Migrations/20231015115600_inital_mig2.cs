using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeProject.Migrations
{
    public partial class inital_mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "İmageUrl",
                table: "MenuDbSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "İmageUrl",
                table: "MenuDbSet");
        }
    }
}
