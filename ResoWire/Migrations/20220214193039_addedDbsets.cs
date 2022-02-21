using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class addedDbsets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "80b154d2-fd42-4c90-b295-ce038df3fda1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f2fe7c1-36f0-4eac-b340-265bc9e55d67", "AQAAAAEAACcQAAAAECI8v27CKLcF3y/6Mfo6zlNw1n/nqhHuPyzhfyCmWCiJnRswtVvucIPht22edIGiqQ==", "98349947-1d17-4d6b-b994-ba470854a034" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "0901965d-2a8c-49a3-be40-2651efbc8a2b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d43390-7838-4112-a6c5-8cc94e307041", "AQAAAAEAACcQAAAAEIvPBuXEp5HqPiAbpH0V18oPl3jn9nticDlo7V9HtmD4WDDW1KPOGGoxkUhwiu33Tg==", "ffe980cd-6617-4883-9860-bec7bded5cc9" });
        }
    }
}
