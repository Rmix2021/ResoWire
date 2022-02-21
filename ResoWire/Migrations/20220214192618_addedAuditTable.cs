using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class addedAuditTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "a9d87d17-4f2f-4ca2-ab87-984cf56a62a9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d7b62f7-4cf5-45d3-b5e4-7a644b56daef", "AQAAAAEAACcQAAAAEB/6OocHpQdNBSueOShh61mckj5kEKtvehphpXUiV+kgUD10TjYuRoeS3TQXpE0ACA==", "28b89682-e537-4fb4-bbcb-ba75546a38f7" });
        }
    }
}
