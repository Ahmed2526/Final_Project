using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class updated_clinic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "Clinics");

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Clinics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_LocationId",
                table: "Clinics",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_SpecialityId",
                table: "Clinics",
                column: "SpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_Locations_LocationId",
                table: "Clinics",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_Specialities_SpecialityId",
                table: "Clinics",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_Locations_LocationId",
                table: "Clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_Specialities_SpecialityId",
                table: "Clinics");

            migrationBuilder.DropIndex(
                name: "IX_Clinics_LocationId",
                table: "Clinics");

            migrationBuilder.DropIndex(
                name: "IX_Clinics_SpecialityId",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Clinics");

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "Clinics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
