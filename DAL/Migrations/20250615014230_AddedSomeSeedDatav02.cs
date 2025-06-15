using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedSomeSeedDatav02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "DoctorId", "LocationId", "Name", "Phone", "Price", "SpecialityId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Heart Care Clinic", "01010010001", 500m, 1 },
                    { 2, 2, 2, "Kids Health Clinic", "01010010002", 350m, 2 },
                    { 3, 3, 3, "Surgical Center", "01010010003", 600m, 3 },
                    { 4, 4, 4, "Skin Wellness Clinic", "01010010004", 400m, 4 },
                    { 5, 5, 5, "Neuro Center", "01010010005", 550m, 5 },
                    { 6, 6, 6, "Women's Health Clinic", "01010010006", 500m, 6 },
                    { 7, 7, 7, "Ortho Move Clinic", "01010010007", 340m, 7 },
                    { 8, 8, 8, "Chronic Care Clinic", "01010010008", 300m, 8 },
                    { 9, 9, 9, "Mind Matters Clinic", "01010010009", 450m, 9 },
                    { 10, 10, 10, "Vision Center", "01010010010", 500m, 10 },
                    { 11, 11, 11, "ENT Specialists", "01010010011", 400m, 11 },
                    { 12, 12, 12, "Pathology Lab", "01010010012", 300m, 12 },
                    { 13, 13, 13, "Endocrine Experts", "01010010013", 450m, 13 },
                    { 14, 14, 14, "Autoimmune Center", "01010010014", 470m, 14 },
                    { 15, 15, 15, "Kidney Care Clinic", "01010010015", 480m, 15 },
                    { 16, 16, 16, "Blood Center", "01010010016", 500m, 16 },
                    { 17, 17, 17, "Digestive Health Clinic", "01010010017", 460m, 17 },
                    { 18, 18, 18, "Family Health Clinic", "01010010018", 350m, 18 },
                    { 19, 19, 19, "Lung & Breathing Clinic", "01010010019", 430m, 19 },
                    { 20, 20, 20, "Cancer Treatment Center", "01010010020", 400m, 20 },
                    { 21, 21, 21, "Imaging Center", "01010010021", 300m, 21 },
                    { 22, 22, 22, "Anesthesia Services", "01010010022", 200m, 22 },
                    { 23, 23, 23, "Smile Dental Clinic", "01010010023", 400m, 23 },
                    { 24, 24, 24, "Uro Care Center", "01010010024", 380m, 24 },
                    { 25, 25, 25, "Beauty & Reconstruction", "01010010025", 750m, 25 },
                    { 26, 26, 26, "Vascular Solutions", "01010010026", 350m, 26 },
                    { 27, 27, 27, "Fertility Center", "01010010027", 450m, 27 },
                    { 28, 28, 28, "Neighborhood GP Clinic", "01010010028", 300m, 5 },
                    { 29, 29, 29, "Little Stars Pediatrics", "01010010029", 370m, 6 },
                    { 30, 30, 30, "Critical Care Hub", "01010010030", 320m, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
