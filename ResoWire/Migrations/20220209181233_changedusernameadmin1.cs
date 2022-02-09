using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class changedusernameadmin1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "172f6cd4-582f-4a03-9ccd-c90cc78f94fb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "44539140-84b8-4056-bacd-dcb1f6d5a282", "AQAAAAEAACcQAAAAENLZ0G8HvfJyksidk+HXw/9fCOpbELCbjeXwZCl7uOyW3OavDnoCEgrWpGEViu20pg==", "415e2786-bf91-492c-b727-c72473e0df10", "Admin1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
