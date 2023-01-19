using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RSCAnderlechtF.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "544ac087-b472-4914-8104-a55bd381d0e9", "2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68bdf9cb-4866-444d-8cf5-56d54170dc81", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1", 0, "ad7b0afe-9de0-4d06-89b7-3c99c1fb23a1", "user1@user.com", true, false, null, "USER1@USER.COM", "USER1@USER.COM", "AQAAAAEAACcQAAAAEKIRriwMA7NsYgQ1jtwAr9qrbSi9p4jw2Vo5QIJzGSuxY4T0TpOSobtJ0tKEiUGmIA==", null, false, "0e6543d0-95d9-4abb-93fa-c3d4d92f02da", false, "user1@user.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "68bdf9cb-4866-444d-8cf5-56d54170dc81", "99d666d3-40ed-4e9d-bc18-e56f2b69dceb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "544ac087-b472-4914-8104-a55bd381d0e9", "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68bdf9cb-4866-444d-8cf5-56d54170dc81", "99d666d3-40ed-4e9d-bc18-e56f2b69dceb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "544ac087-b472-4914-8104-a55bd381d0e9", "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "544ac087-b472-4914-8104-a55bd381d0e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68bdf9cb-4866-444d-8cf5-56d54170dc81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1");
        }
    }
}
