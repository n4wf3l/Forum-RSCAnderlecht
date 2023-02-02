using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RSCAnderlechtF.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEObw7zf7lR9Tlm/yGxEoIjdoZK8oE+EI0JzreR7Li+XOr4EGFCI0rcE3qgSeCyAGNw==", "5c4f58f0-2738-4837-add1-93d22ab50f44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEJqSfiZgMy3/YnxpUyiSjUhRQxcaihz/63jNn3c/Dw+MvEvXWJ+zxK+O8hzUmLheDA==", "f6766762-629d-4c0d-9eaa-97ee8d54a512" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEKG933c+kq2ezRJby6DA6n9Z3Xzv59Rp/XGM53ACRNUmSQdKUEdxvcq9I3gwMsz5FA==", "09a7186a-3efa-4f11-aa44-7c9e4be20c43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEE8o0+j2RecVDweV5B9cdXvgSyvLRVrHjyt7rtPjwvPpkeO23+9buIBfpO5EWSPtcw==", "cdead4bc-8413-4f1a-91f6-166a085d7e8d" });
        }
    }
}
