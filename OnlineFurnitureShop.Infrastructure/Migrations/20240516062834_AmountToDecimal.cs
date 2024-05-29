using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class AmountToDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Carts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7237a305-78c5-4e0e-b7b5-d3069fe034f0", "AQAAAAEAACcQAAAAEKFAjg7L0HB1UGiNL9txTm5/r1mPgsi5/pacWcw9UvBGcJz/CsNVtPe3a25smq+5IA==", "3ac36dcd-d7e2-4900-adc5-a7b220b9205b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49cb1b31-a906-4b3b-bacf-d1c80bc5c1d9", "AQAAAAEAACcQAAAAEG/V43NNCSr5H6HTyK3gDRGX4lSG1H4u6SDc9uMkvbUY4YFEG51VZv4E41OQj118lg==", "3c980c3b-2717-4ae4-83dc-257faf881619" });
        }
    }
}
