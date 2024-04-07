using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6273787c-2bdd-4e4e-a092-0e8599f47a3c", "Guest", "Guestov", "AQAAAAEAACcQAAAAEFnwRexM7kKdPvd5fV9lwAcEaacTh392VHzoEuG3C8uEdCcMzltiEOllRSUklSCeWg==", "3cbd26c7-7b75-46c2-9604-d7a5076970f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db5ca1ca-2d15-42b7-b72c-bd9a7f6b81b4", "Agent", "Agentov", "AQAAAAEAACcQAAAAEJiWDglXJTNsVQ8aCc0XYMH2Q5IessEhILdBXxmeA4nOFtEWTwwbcT0k8OdqQUl63Q==", "3621ad28-b5d7-4b32-af17-2ae5dedc425f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "999313c4-67e6-492f-ae95-c63caebfc2c7", 0, "0c5cde5e-4f85-4a40-b2d3-d98868907e81", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEESiwK+bnFoDLWvalrQ/W2soSognhPkDgQbi+hZjBixpmnqOouFnM7pATVlDemCBmw==", null, false, "9247727d-5e69-42d4-a73e-9816d1abc2ec", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 3, "+359888888887", "999313c4-67e6-492f-ae95-c63caebfc2c7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "999313c4-67e6-492f-ae95-c63caebfc2c7");

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
    }
}
