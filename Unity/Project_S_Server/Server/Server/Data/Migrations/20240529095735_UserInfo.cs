using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Data.Migrations
{
    public partial class UserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userInfo",
                columns: table => new
                {
                    userID = table.Column<string>(nullable: false),
                    iIndex = table.Column<int>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    userName = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInfo", x => x.userID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userInfo");
        }
    }
}
