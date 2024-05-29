using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class CartSubTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3fadca5-ac59-41cf-9ea2-d4a554d4e046", "AQAAAAEAACcQAAAAEMLwzFE40pouwDLuPMkMV+PyK8+ttmXTeYxNrcfRNvLFBZErBoSwXdwbl7Cw3UqpwQ==", "b86f317d-9c0d-412a-bbb5-01801e89ca93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e72907-b71b-47e3-8239-ff3f60e3d9ea", "AQAAAAEAACcQAAAAEKOcDXoxtSTJonhq02tDeVFNSBgJ1vqV0lmZe3Bul26QwWV62AqJ337GKGy+RHoscA==", "fc743f2c-aee0-4bbc-994b-8fbf8806988f" });
        }
    }
}
