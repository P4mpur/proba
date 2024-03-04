using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proba.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObjID",
                table: "Reservations",
                newName: "ObjectID");

            migrationBuilder.RenameColumn(
                name: "UID",
                table: "Reservations",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ObjID",
                table: "Reservations",
                newName: "IX_Reservations_ObjectID");

            migrationBuilder.RenameColumn(
                name: "ObjID",
                table: "Feedbacks",
                newName: "ObjectID");

            migrationBuilder.RenameColumn(
                name: "UID",
                table: "Feedbacks",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_ObjID",
                table: "Feedbacks",
                newName: "IX_Feedbacks_ObjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObjectID",
                table: "Reservations",
                newName: "ObjID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Reservations",
                newName: "UID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ObjectID",
                table: "Reservations",
                newName: "IX_Reservations_ObjID");

            migrationBuilder.RenameColumn(
                name: "ObjectID",
                table: "Feedbacks",
                newName: "ObjID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Feedbacks",
                newName: "UID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_ObjectID",
                table: "Feedbacks",
                newName: "IX_Feedbacks_ObjID");
        }
    }
}
