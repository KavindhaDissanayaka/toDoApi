using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace toDoApi.Migrations
{
    /// <inheritdoc />
    public partial class AltertableaddcolumnsCreateDateEndDateisDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "toDos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "toDos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDone",
                table: "toDos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "toDos");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "toDos");

            migrationBuilder.DropColumn(
                name: "isDone",
                table: "toDos");
        }
    }
}
