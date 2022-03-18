using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace get_shit_done_webapi.Migrations
{
    public partial class finaltables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "Id", "Hash", "Role", "Salt", "Username", "isAdmin", "isDeleted", "isOwner", "isRevoked" },
                values: new object[,]
                {
                    { 1, "", "Owner", "", "JT", true, false, true, false },
                    { 2, "", "Admin", "", "Angel", true, false, false, false },
                    { 3, "", "Admin", "", "Walaa", true, false, false, false },
                    { 4, "", "Specialist", "", "Henry", false, false, false, false },
                    { 5, "", "Specialist", "", "Bob", false, false, false, true },
                    { 6, "", "Specialist", "", "Frank", false, false, false, false },
                    { 7, "", "Specialist", "", "Jacob", false, false, false, true },
                    { 8, "", "Specialist", "", "Jamie", false, false, false, true },
                    { 9, "", "Specialist", "", "John", false, false, false, false },
                    { 10, "", "Specialist", "", "Spleeter", false, false, false, false },
                    { 11, "", "Specialist", "", "Jessie", false, false, false, false },
                    { 12, "", "Specialist", "", "Hector", false, false, false, true },
                    { 13, "", "Specialist", "", "Bobby", false, true, false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
