using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuroraAuto.Migrations
{
    /// <inheritdoc />
    public partial class aspnetroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "29b25dcc-02e1-481d-b854-31543c35edb2", "admin@auroraauto.com", true, false, null, "ADMIN@AURORAAUTO.COM", "ADMIN", "AQAAAAIAAYagAAAAEMVsQR6KFhi+izkKbSZ6pbzWFkshlhRnaq1FnrBL5QIYAnX2WY9ZJkNdSj2xghhRnw==", null, false, "7d5a39c6-13af-42c0-bbb5-f1216fff4d97", false, "Admin" },
                    { "2", 0, "4d6cd1c3-2d62-4de5-880c-1d1b30afd5bc", "ac116531@avcol.school.nz", true, false, null, "AC116531@AVCOL.SCHOOL.NZ", "SHIV", "AQAAAAIAAYagAAAAEGVUiA+RxI/G+clSYWKZuitRUbDvkwROWbNXVzwGrSqSPZNvjQ+4w5KAnOp6Ny2ZQw==", null, false, "fd1429a6-9cfd-43e0-a8a8-9258cebb5dd6", false, "Shiv" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
