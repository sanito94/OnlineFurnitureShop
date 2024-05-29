using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class CartSubTotal1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SubTotal",
                table: "Carts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7597754-1304-48a4-8e2f-d2733eb00252", "AQAAAAEAACcQAAAAEJP1g16trS75NKtBTE/w9dIq75OCJ4sspailg4VICc86eEBRYR0TRlabvLVmzCpbvA==", "6cc56705-d29d-4c87-96bf-54396e63f031" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3fadca5-ac59-41cf-9ea2-d4a554d4e046", "AQAAAAEAACcQAAAAEMLwzFE40pouwDLuPMkMV+PyK8+ttmXTeYxNrcfRNvLFBZErBoSwXdwbl7Cw3UqpwQ==", "b86f317d-9c0d-412a-bbb5-01801e89ca93" });
        }
    }
}
