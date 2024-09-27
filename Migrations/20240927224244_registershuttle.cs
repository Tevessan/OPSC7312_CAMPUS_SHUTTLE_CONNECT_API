using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampusShuttleAPI.Migrations
{
    /// <inheritdoc />
    public partial class registershuttle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisterShuttles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ShuttleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterShuttles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisterShuttles_Shuttles_ShuttleId",
                        column: x => x.ShuttleId,
                        principalTable: "Shuttles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterShuttles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Shuttles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartureTime",
                value: new DateTime(2024, 9, 28, 1, 42, 44, 338, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Shuttles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartureTime",
                value: new DateTime(2024, 9, 28, 2, 42, 44, 338, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.CreateIndex(
                name: "IX_RegisterShuttles_ShuttleId",
                table: "RegisterShuttles",
                column: "ShuttleId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterShuttles_UserId",
                table: "RegisterShuttles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterShuttles");

            migrationBuilder.UpdateData(
                table: "Shuttles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartureTime",
                value: new DateTime(2024, 9, 28, 1, 34, 34, 778, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Shuttles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartureTime",
                value: new DateTime(2024, 9, 28, 2, 34, 34, 778, DateTimeKind.Local).AddTicks(8079));
        }
    }
}
