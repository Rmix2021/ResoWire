using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class addedCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c3c0ac70-4808-4ac7-ac82-ca95dc1aa45a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3375266-a618-4b11-9de2-557569ab1e99", "AQAAAAEAACcQAAAAEKxy/EsTW0vgH5DuNk5O1v8Sx/qP/6Fw0D5XoprLBcTeg7iOZy4ztij3UVr3QdcnsQ==", "9e674220-c52b-4958-9d5f-036ced9b8582" });
        }
    }
}
