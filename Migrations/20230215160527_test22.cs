using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RSCAnderlechtF.Migrations
{
    public partial class test22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEMbjE54dA/8aDnZjM0KqGyxcl194XpKHOD4Gz5cwKDlBG2uqv08xn8JFBpyIN5gNkQ==", "6d4b905a-bcc8-42eb-90f9-9e393c3a7064" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEI5I6xUWVikFNITNr3NDaCQv5zpQrq+pY9gvn0Q3+3rEyzBVI8qtaAU7OhhaYNdLJQ==", "bd7b7674-81ff-4215-9aa1-627a030fe346" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7275));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEFGrJDBXRgWrRbqeEwwLtUDl3/oPbZAM+mA7zsk+JQkJHVJCYeMRZIqtJf5U4eMNXw==", "ea222923-1ac6-40fa-8e39-aff1dc612f66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEMC8dQa4Aiy7aZ5Q5NK/g/AKR00/qzlaIupMVJhkPpQoK31Z2QC5K5uq+CZPovs9PQ==", "7a167928-7e30-4399-977d-1b9883894002" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 16, 3, 12, 136, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 15, 16, 3, 12, 136, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 2, 15, 16, 3, 12, 136, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 2, 15, 16, 3, 12, 136, DateTimeKind.Utc).AddTicks(2186));
        }
    }
}
