using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CurseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Curses",
                columns: new[] { "Id", "Text" },
                values: new object[] { 1, "Po šimts pypkių!" });

            migrationBuilder.InsertData(
                table: "Curses",
                columns: new[] { "Id", "Text" },
                values: new object[] { 2, "Rupūs miltai!" });

            migrationBuilder.InsertData(
                table: "Curses",
                columns: new[] { "Id", "Text" },
                values: new object[] { 3, "Kad tau grybai ausis užkištų!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
