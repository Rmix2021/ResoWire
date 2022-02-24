using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResoWire.Migrations
{
    public partial class addedAssignedToProperty2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "Issues");
        }
    }
}
