using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class removeWhiteSpace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                column: "BoardTitle",
                value: "DnDMeetUp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                column: "BoardTitle",
                value: "DnD MeetUp");
        }
    }
}
