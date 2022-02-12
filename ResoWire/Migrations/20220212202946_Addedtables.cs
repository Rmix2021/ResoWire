using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class Addedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLogins",
                keyColumn: "UserId",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5dd99aef-df4e-460d-a1d4-80284a88da5e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a07e066-5af4-45ae-87aa-a8f321bfe4b9", "AQAAAAEAACcQAAAAEJrSOijosKxKmiat7CxYF7xeLULDkGtfaKzAvDm9/AEacH0HdPQwv5HieFTZxtERLA==", "54cc94b2-7e5e-404f-ad9d-0d1017c0c237" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "172f6cd4-582f-4a03-9ccd-c90cc78f94fb");

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "UserId", "LoginProvider", "ProviderDisplayName", "ProviderKey" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", null, "MasterOfDeeesaster", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44539140-84b8-4056-bacd-dcb1f6d5a282", "AQAAAAEAACcQAAAAENLZ0G8HvfJyksidk+HXw/9fCOpbELCbjeXwZCl7uOyW3OavDnoCEgrWpGEViu20pg==", "415e2786-bf91-492c-b727-c72473e0df10" });
        }
    }
}
