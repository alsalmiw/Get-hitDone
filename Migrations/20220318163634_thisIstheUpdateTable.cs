using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace get_shit_done_webapi.Migrations
{
    public partial class thisIstheUpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "specialistId",
                table: "TaskInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "specialistName",
                table: "TaskInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ProjectInfo",
                columns: new[] { "Id", "DateCreate", "DueDate", "PriorityOfProject", "ProjectDescription", "ProjectName", "StatusOfProject", "UserId", "isArchived", "isDeleted" },
                values: new object[,]
                {
                    { 1, "3/18/22", "3/30/22", "Low", "Check if food is expired", "Expired?", "InProgress", 1, false, false },
                    { 2, "6/12/22", "7/30/22", "Medium", "Check if food is expired", "Expired?", "InProgress", 2, false, true },
                    { 3, "3/15/22", "4/01/22", "High", "Pick a Movie with your Friends", "ChickFlicks", "Completed", 3, false, false },
                    { 4, "8/2/22", "4/01/23", "High", "Sell Burger", "BurgerShot", "Completed", 4, false, true }
                });

            migrationBuilder.InsertData(
                table: "SpecialistProjectInfo",
                columns: new[] { "Id", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 2, 1 },
                    { 5, 3, 1 },
                    { 6, 4, 2 },
                    { 7, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "TaskInfo",
                columns: new[] { "Id", "PriorityOfTask", "ProjectId", "StatusOfTask", "TaskDateCreate", "TaskDescription", "TaskDueDate", "TaskIsDeleted", "TaskName", "TaskisArchived", "specialistId", "specialistName" },
                values: new object[,]
                {
                    { 1, "High", 3, "InProgress", "Build Front End for ChicksFlicks", "Create the front end for app", "05/01/2022", false, "ChickFlicksFrontEnd", false, 2, "An" },
                    { 2, "High", 3, "Completed", "Build Back End for ChicksFlicks", "Create the back end for app", "05/01/2022", false, "ChickFlicksBackEnd", false, 6, "Hector" },
                    { 3, "Low", 1, "InProgress", "Build Front End for Expired?", "Create the front end for app", "05/01/2022", false, "Expired? Front End", false, 3, "Jessie" },
                    { 4, "Low", 4, "InProgress", "Build Back End for BurgerShot", "Create the back end for BurgerShot", "03/18/2022", false, "BurgerShot BackEnd", false, 2, "Bob" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SpecialistProjectInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SpecialistProjectInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SpecialistProjectInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SpecialistProjectInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SpecialistProjectInfo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SpecialistProjectInfo",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SpecialistProjectInfo",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TaskInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "specialistId",
                table: "TaskInfo");

            migrationBuilder.DropColumn(
                name: "specialistName",
                table: "TaskInfo");
        }
    }
}
