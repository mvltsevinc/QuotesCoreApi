using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesApi.Migrations
{
    public partial class UserIdRequiredRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Quotes",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Quotes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
