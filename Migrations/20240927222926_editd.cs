using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusShuttleAPI.Migrations
{
    /// <inheritdoc />
    public partial class editd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shuttles_Users_UserId",
                table: "Shuttles");

            migrationBuilder.DropIndex(
                name: "IX_Shuttles_UserId",
                table: "Shuttles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Shuttles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Shuttles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shuttles_UserId",
                table: "Shuttles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shuttles_Users_UserId",
                table: "Shuttles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
