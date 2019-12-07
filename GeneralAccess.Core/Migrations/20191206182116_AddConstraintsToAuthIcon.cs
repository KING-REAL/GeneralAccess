using Microsoft.EntityFrameworkCore.Migrations;

namespace GeneralAccess.Core.Migrations
{
    public partial class AddConstraintsToAuthIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IconCode",
                table: "AuthIcons",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IconCode",
                table: "AuthIcons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
