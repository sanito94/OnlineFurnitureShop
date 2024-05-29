using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class AmountToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e826a6e2-c82d-459b-9652-17ba903e1450", "AQAAAAEAACcQAAAAEBqgon5Q1OXBZsNDCgxJL19JakLN+EJ3T2yBQdyoj9OTGtlTLEOfGMBIvIKFvRNlgw==", "69e72542-288a-4a66-90fa-cf357cb143cd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
