using Microsoft.EntityFrameworkCore.Migrations;

namespace Assessment.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatchTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sport = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
