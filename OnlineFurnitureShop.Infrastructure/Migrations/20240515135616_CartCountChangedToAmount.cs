using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class CartCountChangedToAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Carts",
                newName: "Amount");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49cb1b31-a906-4b3b-bacf-d1c80bc5c1d9", "AQAAAAEAACcQAAAAEG/V43NNCSr5H6HTyK3gDRGX4lSG1H4u6SDc9uMkvbUY4YFEG51VZv4E41OQj118lg==", "3c980c3b-2717-4ae4-83dc-257faf881619" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Carts",
                newName: "Count");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8de76e2-4ff4-42a2-9db2-fe3394fa6507", "AQAAAAEAACcQAAAAECbwIy2PnhyFpUaJwy8DuMxUMx//bTJMIPM2cBe+sq02eYXmuHDl2XR/PXKj2gcOCQ==", "0df97bd9-ba96-40ee-bc6e-581f8bccf1a8" });
        }
    }
}
