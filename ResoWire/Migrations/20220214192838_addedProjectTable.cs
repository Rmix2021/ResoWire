using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class addedProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "6f195f24-cec7-4908-a80f-55bd1ccbd862");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4770db00-cff6-4ee0-95fc-06f6078e2842", "AQAAAAEAACcQAAAAEGYgTAb+GwDZHu6IPKdXZlLIDvg8CYl/VO16udcvlY0WXoF3/jFSDDyKJmsX0B2VVw==", "207ad145-d3fe-4b9e-b944-96858304113c" });
        }
    }
}
