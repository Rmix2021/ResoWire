using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class reAddedDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "533deaac-73e2-45cd-8bae-300f48353938");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76208acd-4099-4fa7-8ba5-e5124671bb27", "AQAAAAEAACcQAAAAEFLMfAWh6JBMGgmjH5wuSjRLD7ik/rm6VkaNX2I8op/nTlgf8Nw0Aarxn/3tLn5IbQ==", "1ccd0f44-937e-47fd-8ba3-e53d38853c79" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "d83c58ed-4a7b-4994-82f4-c245f1ea880f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c80c037-04d4-4890-8aa0-dab9f6729ef1", "AQAAAAEAACcQAAAAEIdEuMSNjijOWvCSY04lA7Z1YSOfy1g8AZSXuUCRbQDmYNVIMeBe5+opGRP2QpuBMw==", "2cfc69e8-b5cf-4477-9e27-b8e609e5558a" });
        }
    }
}
