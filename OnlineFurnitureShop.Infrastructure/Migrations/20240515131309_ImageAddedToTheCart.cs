using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class ImageAddedToTheCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8de76e2-4ff4-42a2-9db2-fe3394fa6507", "AQAAAAEAACcQAAAAECbwIy2PnhyFpUaJwy8DuMxUMx//bTJMIPM2cBe+sq02eYXmuHDl2XR/PXKj2gcOCQ==", "0df97bd9-ba96-40ee-bc6e-581f8bccf1a8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97c4e77c-786f-4804-bb33-f15f62311a6a", "AQAAAAEAACcQAAAAECQtTs/o/7LcKPuN1uvATonZoeSFjs1qcU06bYfsC3QOTKgHMhXn5O9+xD3nzFOoBA==", "dea68619-1011-47ce-914d-f6a11c1e0be4" });
        }
    }
}
