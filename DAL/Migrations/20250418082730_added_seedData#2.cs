using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class added_seedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "أخصائي حساسية/مناعة");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "أخصائي تخدير");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "أخصائي قلب");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "أخصائي جلدية");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "أخصائي غدد صماء");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "أخصائي جهاز هضمي");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "طبيب عام");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "أخصائي طب كبار السن");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "أخصائي دم");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "أخصائي أمراض معدية");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "طبيب باطنية");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "أخصائي كلى");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "أخصائي أعصاب");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "أخصائي نساء وتوليد");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "أخصائي أورام");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "أخصائي عيون");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "جراح عظام");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "أخصائي أنف وأذن وحنجرة");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "أخصائي أمراض Pathology");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "أخصائي أطفال");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "جراح تجميل");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "أخصائي نفسية");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "أخصائي صدر");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "أخصائي أشعة");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "أخصائي روماتيزم");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "جراح عام");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "أخصائي مسالك بولية");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Allergist/Immunologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Anesthesiologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Cardiologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Dermatologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Endocrinologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Gastroenterologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "General Practitioner");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Geriatrician");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Hematologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Infectious Disease Specialist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Internist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Nephrologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Neurologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Obstetrician/Gynecologist (OB/GYN)");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Oncologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Ophthalmologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Orthopedic Surgeon");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Otolaryngologist (ENT)");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Pathologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Pediatrician");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Plastic Surgeon");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Psychiatrist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Pulmonologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Radiologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Rheumatologist");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Surgeon (General)");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Urologist");
        }
    }
}
