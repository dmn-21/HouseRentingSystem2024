using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e7f18f1-2c27-4504-b399-8da46dc8893d", "AQAAAAEAACcQAAAAEHVh4/I9uqwRuRi/2ot+cg05nKuSRNXk7oCUfiJPsTVUh8yrj5sW25FfzfIY90+GCQ==", "cb0fb277-139e-4349-9492-9d420296530d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c547a6e1-6058-40f2-8718-7f6e8eecbc79", "AQAAAAEAACcQAAAAECFeIrzSCn+KS3+sV1lMc7dPfdTE5K/iaq6JlOaVhs+7MTplxeit/PW7+ZohxM7YIw==", "73d2c8a6-9ca1-49d9-82b4-fcbf26dbe743" });
        }
    }
}
