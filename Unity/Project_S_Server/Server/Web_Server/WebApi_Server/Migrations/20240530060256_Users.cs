using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_Server.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_userInfo",
                table: "userInfo");

            migrationBuilder.RenameTable(
                name: "userInfo",
                newName: "users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "userInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userInfo",
                table: "userInfo",
                column: "userID");
        }
    }
}
