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
                values: new object[,]
                {
                    { 1, "Po šimts pypkių!" },
                    { 21, "Pakasyk sliekui pažastį!" },
                    { 20, "Surūgsi kaip kisielius!" },
                    { 19, "Kramtyk mėšlą" },
                    { 18, "O tu šuns kumpi" },
                    { 17, "Ko prikibai kaip lapas prie užpakalio!" },
                    { 16, "Papūsk šuniui į uodegą!" },
                    { 15, "Eik tu kiaulėms uodegas mazgoti" },
                    { 14, "Elniaragį tau į subinę" },
                    { 13, "Įsikąsk į stuburą" },
                    { 22, "Kad tave varnos sulestų!" },
                    { 12, "Šliaušk tarybiniais vamzdžiais" },
                    { 10, "Ot tu šuns pasturgali" },
                    { 9, "Papūsk dyglei į rankovę!" },
                    { 8, "Žalčio koja pastaroji!" },
                    { 7, "Kad tave zuikis subadytų!" },
                    { 6, "Po šimts gegučių!" },
                    { 5, "Eik tu balų degint" },
                    { 4, "Kad tave šunys užmirštų" },
                    { 3, "Kad tau grybai ausis užkištų!" },
                    { 2, "Rupūs miltai!" },
                    { 11, "Apsišik aukštielninkas" },
                    { 23, "Snarglių kompotas!" }
                });
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

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Curses",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
