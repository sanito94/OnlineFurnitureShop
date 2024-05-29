using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFurnitureShop.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5321f824-d6f9-4a58-beef-03b7bc3d6fa4", 0, "ul. Pliska 4, bl. Preslav, grad Ruse", "68904d07-d6ce-47b2-a6d7-021a77dc9fb5", "ApplicationUser", "admin@gmail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPthqiv9ZGjPLsnNijQ8HlXn8T0nAYasgcT0E9f+XRcxRRS/KlAuxCxJrHDaHpD/nA==", "+491787181664", false, "7000", "747b4020-e7e2-434a-a187-8747345cc914", false, "admin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5321f824-d6f9-4a58-beef-03b7bc3d6fa4");
        }
    }
}
