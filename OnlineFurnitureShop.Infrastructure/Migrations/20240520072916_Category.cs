using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd7033e5-2e6e-473b-99a5-175feb699e5b", "AQAAAAEAACcQAAAAEOaTejFx4YcUXdLDgR7sf7xrzfoPzUrk9F/3kdOA3bGMU/2sRg9A7701CWiJ+L1//Q==", "a9e7484a-b52c-4827-9e06-be328ce5b28a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ade852c-2d31-4504-b466-33f38e7beea5", "AQAAAAEAACcQAAAAEP/+Aby565p3QhSyVNT8lGN0mG6GY42A4S+FOMSMyqjUK/70G5DDK6aIVCcDnaLvmg==", "11eee5cc-ea5d-4dcc-9069-d64e60176cfe" });
        }
    }
}
