using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class ItemImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7357ef76-2333-480a-86f9-9c890b33c43d", "AQAAAAEAACcQAAAAECViVe3d8hVK5cTyRIuf2tZUM9LdNuCeOXnhEWE9JYpYM3pID+xUH4qArAEF0DkjUw==", "e084b388-5cbe-4ec2-a516-5ce18552bbea" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://st2.depositphotos.com/8816906/45463/i/450/depositphotos_454638350-stock-photo-front-side-view-black-green.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bfd20c1-e3e2-49a5-9804-25b25d446c68", "AQAAAAEAACcQAAAAENlQCvLrlAkPrvuacl7/lMeBgNzdlejB05einzNDe4THzrHcn1ccsy6B628uCQ+Jxw==", "2ea0749d-fc60-4a7d-8b7c-fbd1a87ebf4d" });
        }
    }
}
