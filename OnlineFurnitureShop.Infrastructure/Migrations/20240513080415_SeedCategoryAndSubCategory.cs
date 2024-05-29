using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class SeedCategoryAndSubCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dadbd537-a7a6-4a35-b1c1-2f19a8da48ef", "AQAAAAEAACcQAAAAECDQkJCsdlQrtc5aPDsJDMiYHEjpLqmhGwUzoGMma0YGC1a/aV2ZXlxBSUh9S/N9Kw==", "4aeed168-c425-418f-b7fb-52ccdc793e97" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Chair" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 1, 1, "Wood" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 2, 1, "Leather" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68904d07-d6ce-47b2-a6d7-021a77dc9fb5", "AQAAAAEAACcQAAAAEPthqiv9ZGjPLsnNijQ8HlXn8T0nAYasgcT0E9f+XRcxRRS/KlAuxCxJrHDaHpD/nA==", "747b4020-e7e2-434a-a187-8747345cc914" });
        }
    }
}
