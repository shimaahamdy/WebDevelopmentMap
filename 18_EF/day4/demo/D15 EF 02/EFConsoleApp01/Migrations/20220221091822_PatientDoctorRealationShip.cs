using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsoleApp01.Migrations
{
    public partial class PatientDoctorRealationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorPatient",
                columns: table => new
                {
                    PatientsPID = table.Column<int>(type: "int", nullable: false),
                    doctorsDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatient", x => new { x.PatientsPID, x.doctorsDID });
                    
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Doctors_doctorsDID",
                        column: x => x.doctorsDID,
                        principalTable: "Doctors",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Patients_PatientsPID",
                        column: x => x.PatientsPID,
                        principalTable: "Patients",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_doctorsDID",
                table: "DoctorPatient",
                column: "doctorsDID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorPatient");
        }
    }
}
