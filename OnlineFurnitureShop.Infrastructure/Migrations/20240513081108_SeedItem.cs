using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class SeedItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bfd20c1-e3e2-49a5-9804-25b25d446c68", "AQAAAAEAACcQAAAAENlQCvLrlAkPrvuacl7/lMeBgNzdlejB05einzNDe4THzrHcn1ccsy6B628uCQ+Jxw==", "2ea0749d-fc60-4a7d-8b7c-fbd1a87ebf4d" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "SubCategoryId" },
                values: new object[] { 1, 1, "Super cool gaming chair and very comfy", "Leather Gaming Chair PZ3000", 10.0, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dadbd537-a7a6-4a35-b1c1-2f19a8da48ef", "AQAAAAEAACcQAAAAECDQkJCsdlQrtc5aPDsJDMiYHEjpLqmhGwUzoGMma0YGC1a/aV2ZXlxBSUh9S/N9Kw==", "4aeed168-c425-418f-b7fb-52ccdc793e97" });
        }
    }
}
