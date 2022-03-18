using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsoleApp01.Migrations
{
    public partial class CliencVists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clienc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PatientClienc",
                columns: table => new
                {
                    CliencID = table.Column<int>(type: "int", nullable: false),
                    PatientPID = table.Column<int>(type: "int", nullable: false),
                    Visit = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientClienc", x => new { x.PatientPID, x.CliencID });
                    table.ForeignKey(
                        name: "FK_PatientClienc_Clienc_CliencID",
                        column: x => x.CliencID,
                        principalTable: "Clienc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientClienc_Patients_PatientPID",
                        column: x => x.PatientPID,
                        principalTable: "Patients",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientClienc_CliencID",
                table: "PatientClienc",
                column: "CliencID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientClienc");

            migrationBuilder.DropTable(
                name: "Clienc");
        }
    }
}
