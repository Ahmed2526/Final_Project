using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedChedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "DoctorAvailabilities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAvailabilities_ClinicId",
                table: "DoctorAvailabilities",
                column: "ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorAvailabilities_Clinics_ClinicId",
                table: "DoctorAvailabilities",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorAvailabilities_Clinics_ClinicId",
                table: "DoctorAvailabilities");

            migrationBuilder.DropIndex(
                name: "IX_DoctorAvailabilities_ClinicId",
                table: "DoctorAvailabilities");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "DoctorAvailabilities");
        }
    }
}
