using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace toDoApi.Migrations
{
    /// <inheritdoc />
    public partial class todonumberadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "toDoNo",
                table: "toDos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "toDoNo",
                table: "toDos");
        }

    }
}
