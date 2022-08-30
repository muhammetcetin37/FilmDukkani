using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Film.DAL.Migrations
{
    public partial class Login_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Uyeler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Uyeler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Uyeler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Uyeler");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Uyeler");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Uyeler");
        }
    }
}
