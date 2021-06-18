using Microsoft.EntityFrameworkCore.Migrations;

namespace medical_appointments.Data.Migrations
{
    public partial class AddPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientCompanionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientCompanionSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientStreetAddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientPostaCode = table.Column<int>(type: "int", nullable: false),
                    PatientNumberCode = table.Column<int>(type: "int", nullable: false),
                    PatientNumber = table.Column<int>(type: "int", nullable: false),
                    PatientNumberWhatsapp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
