using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class IsApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89889742-580f-4183-afaf-850db477a674", "AQAAAAEAACcQAAAAED0mf8wPphPZuI3KlF8Q+6r3Hc2rAy4hnhDgMh8zO9HNaazZmoERYIvgurklEGtVxA==", "ff0d873c-366e-42d0-a4aa-9aa05f9a544c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "999313c4-67e6-492f-ae95-c63caebfc2c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30a5c8d9-84a1-4d52-91ec-16781a2b46ff", "AQAAAAEAACcQAAAAEFEpKfvygir5U6aKPvI3LcPYvt7NT1om5zXuBKu7ZJCMuA5+JZF79i8JcA7qxUBmmg==", "95f05758-a9b8-456c-a471-0626261bcf70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da0a31e9-de00-4497-8014-f23907f0a090", "AQAAAAEAACcQAAAAEG2A8OxLA9s2kxbge1EAeZMPVooAp4grvP24A/HREhb18HiukV2A3xexLyT0edJkgw==", "a2a200ad-5017-4212-9ca2-b9becf5bcb1c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6273787c-2bdd-4e4e-a092-0e8599f47a3c", "AQAAAAEAACcQAAAAEFnwRexM7kKdPvd5fV9lwAcEaacTh392VHzoEuG3C8uEdCcMzltiEOllRSUklSCeWg==", "3cbd26c7-7b75-46c2-9604-d7a5076970f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "999313c4-67e6-492f-ae95-c63caebfc2c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c5cde5e-4f85-4a40-b2d3-d98868907e81", "AQAAAAEAACcQAAAAEESiwK+bnFoDLWvalrQ/W2soSognhPkDgQbi+hZjBixpmnqOouFnM7pATVlDemCBmw==", "9247727d-5e69-42d4-a73e-9816d1abc2ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db5ca1ca-2d15-42b7-b72c-bd9a7f6b81b4", "AQAAAAEAACcQAAAAEJiWDglXJTNsVQ8aCc0XYMH2Q5IessEhILdBXxmeA4nOFtEWTwwbcT0k8OdqQUl63Q==", "3621ad28-b5d7-4b32-af17-2ae5dedc425f" });
        }
    }
}
