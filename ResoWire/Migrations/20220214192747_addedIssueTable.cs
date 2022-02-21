using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class addedIssueTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "10d72fbe-8a2d-4caa-89e3-93b90a8de05a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "806636bf-d7be-4c01-b66b-f1e49667c350", "AQAAAAEAACcQAAAAEL3sidYAZl8fy89RKCSOrCfrL45LKCi3YyvaXQ9JMu0DQ82y/GWe9NP0E0D1LnMl9g==", "22da1eda-c5a0-4e45-b532-050d20d79379" });
        }
    }
}
