using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class gg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    
            migrationBuilder.DropTable(
                name: "Friends");





            migrationBuilder.DropTable(
                name: "TimeCapsule");

            migrationBuilder.DropTable(
                name: "TimeCapsuleFiles");

            migrationBuilder.DropTable(
                name: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "ImageFiles");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "StringFiles");

            migrationBuilder.DropTable(
                name: "TimeCapsule");

            migrationBuilder.DropTable(
                name: "TimeCapsuleFiles");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
