using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TGL.WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Cpu = table.Column<double>(nullable: false),
                    Ram = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Age = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false),
                    Nit = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computer");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
