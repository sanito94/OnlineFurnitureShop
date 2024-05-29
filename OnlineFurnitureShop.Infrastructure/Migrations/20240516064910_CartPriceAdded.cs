using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class CartPriceAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Carts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ade852c-2d31-4504-b466-33f38e7beea5", "AQAAAAEAACcQAAAAEP/+Aby565p3QhSyVNT8lGN0mG6GY42A4S+FOMSMyqjUK/70G5DDK6aIVCcDnaLvmg==", "11eee5cc-ea5d-4dcc-9069-d64e60176cfe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0e9d4d6-cf77-4b9c-a978-74af23c76fac", "AQAAAAEAACcQAAAAEKN36z/o96hfjKrl+3/48eGOReC13wX84G0WBBbgCxhUCMCErqDx+1Ry6gGLCcdeCg==", "d493da5f-dfe7-4b9b-a04e-58f55ff1f51b" });
        }
    }
}
