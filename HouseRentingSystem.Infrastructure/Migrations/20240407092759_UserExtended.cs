using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b744f4-fa3e-47f6-a8ec-19d3bcdf7c1a", "", "", "AQAAAAEAACcQAAAAEK9Dnig6yMNjtI7MC5geg/qbwCQydpGamwKcGMLbgrpLwEnsjUOB9yywEEf2woaIdA==", "7a892e8a-4db4-479c-a0ff-0765a939417d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5a76ad2-5a45-4135-bea0-2207c4086603", "", "", "AQAAAAEAACcQAAAAEIvteLjNRunBJogfnfOgkGAwlXYE4yPIypVM25FCRktOJoadq9Ru3IxW4z7EA/mzSw==", "9f549133-033e-4a01-a053-3afea6c7bf26" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a9d9bc8-b95c-477b-b5c0-fc37aa13ee26", "AQAAAAEAACcQAAAAEA7IdbazWSieR9/ANoSeZDYdFVhfa1A9NQ0L3KQBJNWM1Jj/8hJokHst6btqpA4FsQ==", "f80c2d40-61d4-4926-ba0a-f3b3a7cf18ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19d1c4b3-21b3-4874-861c-8c6d5a2436f7", "AQAAAAEAACcQAAAAEDdQHUgFpecwrhqqnPENcEG5v+tma4WtQvjuEymImiOacWEWzkjtVKPuXsbu/S5KBA==", "acdada19-84f6-4a58-bdb4-3c7187559799" });
        }
    }
}
