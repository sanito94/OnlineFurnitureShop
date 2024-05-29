using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class SeedChairs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97c4e77c-786f-4804-bb33-f15f62311a6a", "AQAAAAEAACcQAAAAECQtTs/o/7LcKPuN1uvATonZoeSFjs1qcU06bYfsC3QOTKgHMhXn5O9+xD3nzFOoBA==", "dea68619-1011-47ce-914d-f6a11c1e0be4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://png.pngtree.com/png-clipart/20230213/ourmid/pngtree-black-gaming-chair-png-image_6596551.png", "Leather Gaming Chair PK2000", 30.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "SubCategoryId" },
                values: new object[,]
                {
                    { 2, 1, "Gaming Chair from the best leather", "https://png.pngtree.com/png-clipart/20230316/ourmid/pngtree-realistic-3d-gaming-chair-yellow-and-black-color-png-image_6652203.png", "Gaming Chair PK1200", 20.0, 2 },
                    { 3, 1, "Wood chair but very comfy", "https://png.pngtree.com/png-vector/20230912/ourmid/pngtree-home-and-office-wooden-chair-isolated-png-image_10025185.png", "Wood Chair", 5.0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "916af024-7685-4a98-8610-7e7b4233976e", "AQAAAAEAACcQAAAAEGfvQSEUw3HKI+AD1uzXqxsOEqaDjKBHJnG3sZFGA7m22ByCc55bc3y86C36N1Rx3w==", "2d57d7e4-14ab-4271-bd0f-99b1d61ef2e0" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://st2.depositphotos.com/8816906/45463/i/450/depositphotos_454638350-stock-photo-front-side-view-black-green.jpg", "Leather Gaming Chair PZ3000", 10.0 });
        }
    }
}
