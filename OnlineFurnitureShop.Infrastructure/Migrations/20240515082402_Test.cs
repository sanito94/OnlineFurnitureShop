using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "916af024-7685-4a98-8610-7e7b4233976e", "AQAAAAEAACcQAAAAEGfvQSEUw3HKI+AD1uzXqxsOEqaDjKBHJnG3sZFGA7m22ByCc55bc3y86C36N1Rx3w==", "2d57d7e4-14ab-4271-bd0f-99b1d61ef2e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7357ef76-2333-480a-86f9-9c890b33c43d", "AQAAAAEAACcQAAAAECViVe3d8hVK5cTyRIuf2tZUM9LdNuCeOXnhEWE9JYpYM3pID+xUH4qArAEF0DkjUw==", "e084b388-5cbe-4ec2-a516-5ce18552bbea" });
        }
    }
}
