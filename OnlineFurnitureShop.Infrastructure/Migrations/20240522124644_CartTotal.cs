using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class CartTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Carts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e72907-b71b-47e3-8239-ff3f60e3d9ea", "AQAAAAEAACcQAAAAEKOcDXoxtSTJonhq02tDeVFNSBgJ1vqV0lmZe3Bul26QwWV62AqJ337GKGy+RHoscA==", "fc743f2c-aee0-4bbc-994b-8fbf8806988f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6872febc-fbb7-43ca-b33d-aa5c4bb767af", "AQAAAAEAACcQAAAAEKd0S3EXVUcnlcS3l+2a4zS1+kVZ7LBdmEFs0XqzK8D8snuFBgeDLUDxIwNy7MlrUA==", "7698c08c-a719-43b2-8644-3b531aa516f6" });
        }
    }
}
