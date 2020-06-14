using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    game_result = table.Column<string>(type: "varchar(20)", nullable: false),
                    first_player_name = table.Column<string>(type: "varchar(150)", nullable: false),
                    first_player_element = table.Column<string>(type: "varchar(10)", nullable: false),
                    second_player = table.Column<string>(type: "varchar(150)", nullable: false),
                    second_player_element = table.Column<string>(type: "varchar(10)", nullable: false),
                    game_date = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_history", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "history");
        }
    }
}
