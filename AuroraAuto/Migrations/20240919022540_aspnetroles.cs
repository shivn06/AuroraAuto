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
                    { "1", 0, "0bf57410-20b5-41eb-83d0-9eb0f1584daf", "admin@auroraauto.com", true, false, null, "ADMIN@AURORAAUTO.COM", "ADMIN", "AQAAAAIAAYagAAAAEAC2lpcX/vpzL3h/HRPFB4+NcC5ggAntx/uRt3tN9XxjlJ3vmFxeqwZ+sjx5MQc5iA==", null, false, "566f48cf-77de-4aef-bf37-c0f2967fb5b5", false, "Admin" },
                    { "2", 0, "7189a09b-c5a8-4684-a845-36de5c288ddb", "ac116531@avcol.school.nz", true, false, null, "AC116531@AVCOL.SCHOOL.NZ", "SHIV", "AQAAAAIAAYagAAAAECktPv2CQuu0v1S00/ztexRn9NMCTC9U5axf44F9z0b9YWpneGGP5cZ1rsLxpAHzLA==", null, false, "b747d120-0ac0-4391-9f7d-a47b01556103", false, "Shiv" }
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
