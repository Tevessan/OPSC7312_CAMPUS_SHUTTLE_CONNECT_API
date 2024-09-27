using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusShuttleAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shuttles",
                columns: new[] { "Id", "DepartureTime", "Destination" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 28, 1, 34, 34, 778, DateTimeKind.Local).AddTicks(8057), "Sandton Gautrain Station" },
                    { 2, new DateTime(2024, 9, 28, 2, 34, 34, 778, DateTimeKind.Local).AddTicks(8079), "Varsity College Sandton" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "user1@example.com", "password1" },
                    { 2, "user2@example.com", "password2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shuttles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shuttles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
