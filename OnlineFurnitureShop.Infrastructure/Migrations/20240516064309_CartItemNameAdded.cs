using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class CartItemNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0e9d4d6-cf77-4b9c-a978-74af23c76fac", "AQAAAAEAACcQAAAAEKN36z/o96hfjKrl+3/48eGOReC13wX84G0WBBbgCxhUCMCErqDx+1Ry6gGLCcdeCg==", "d493da5f-dfe7-4b9b-a04e-58f55ff1f51b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e826a6e2-c82d-459b-9652-17ba903e1450", "AQAAAAEAACcQAAAAEBqgon5Q1OXBZsNDCgxJL19JakLN+EJ3T2yBQdyoj9OTGtlTLEOfGMBIvIKFvRNlgw==", "69e72542-288a-4a66-90fa-cf357cb143cd" });
        }
    }
}
