using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BME77.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_C = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    Chair = table.Column<string>(nullable: true),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    IsWorkshop = table.Column<bool>(nullable: false),
                    IsOral = table.Column<bool>(nullable: false),
                    IsKeyLab = table.Column<bool>(nullable: false),
                    IsBreak = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abstract = table.Column<string>(nullable: true),
                    SessionID = table.Column<int>(nullable: false),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    FullTextLink = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Paper_Session_SessionID",
                        column: x => x.SessionID,
                        principalTable: "Session",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paper_SessionID",
                table: "Paper",
                column: "SessionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paper");

            migrationBuilder.DropTable(
                name: "Session");
        }
    }
}
