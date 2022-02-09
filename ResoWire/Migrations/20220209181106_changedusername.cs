using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class changedusername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ccba8269-b23e-4b58-ab01-e27806b7771c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e7583b59-dda3-4865-96ff-b2a985a13266", "AQAAAAEAACcQAAAAEOmlHqywHztIcy0mQu4G+jpHluJqVGNX96nU8CZbDSR4CwKYQU7iSVkLbgIrJhtiJw==", "87c4a19f-8ae5-40ab-9feb-b3be655d0bb2", "Name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "9142e669-a6f6-4c3b-9f13-7ddf916ae425");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5db9b6fa-ff42-4d66-9015-6341d87a221b", "AQAAAAEAACcQAAAAEAfxfJ8HIaHn8kObUFKhha1PUVKaYv+71Aw/5svAOGfD8xJ2swXDBRlFz5JJEOUlxQ==", "631e810c-f161-4593-8d08-00c0c09f1a29", "eurotuner1981@gmail.com" });
        }
    }
}
