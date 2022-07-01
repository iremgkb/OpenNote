using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenNoteAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreatedTime", "ModifiedTime", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet.", new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9179), new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9189), "Sample Note 1" },
                    { 2, "Doloribus ea impedit magnam.", new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9191), new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9192), "Sample Note 2" },
                    { 3, "Error, quis laborum.", new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9193), new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9193), "Sample Note 3" },
                    { 4, "Error doloribus saepe animi natus.", new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9194), new DateTime(2022, 7, 1, 15, 42, 10, 624, DateTimeKind.Local).AddTicks(9194), "Sample Note 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
