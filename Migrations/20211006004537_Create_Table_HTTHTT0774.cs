using Microsoft.EntityFrameworkCore.Migrations;

namespace HoangTrungThong774.Migrations
{
    public partial class Create_Table_HTTHTT0774 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonName",
                table: "PersonHTT774",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "PersonHTT774",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "HTT0774",
                columns: table => new
                {
                    HTTId = table.Column<string>(nullable: false),
                    HTTName = table.Column<string>(nullable: false),
                    HTTGender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HTT0774", x => x.HTTId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HTT0774");

            migrationBuilder.AlterColumn<string>(
                name: "PersonName",
                table: "PersonHTT774",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "PersonHTT774",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
