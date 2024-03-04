using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proba.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObjectID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ObjectID",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Feedbacks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ObjectID",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObjectID",
                table: "Feedbacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Feedbacks",
                type: "int",
                nullable: true);
        }
    }
}
