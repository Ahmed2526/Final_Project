using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedSomeSeedDatav03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DoctorAvailabilities",
                columns: new[] { "Id", "AppointmentEnd", "AppointmentStart", "ClinicId", "Day", "DoctorId" },
                values: new object[,]
                {
                    { 1, new TimeOnly(17, 0, 0), new TimeOnly(9, 0, 0), 1, "Monday", 1 },
                    { 2, new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0), 2, "Tuesday", 2 },
                    { 3, new TimeOnly(16, 30, 0), new TimeOnly(8, 30, 0), 3, "Wednesday", 3 },
                    { 4, new TimeOnly(19, 0, 0), new TimeOnly(11, 0, 0), 4, "Thursday", 4 },
                    { 5, new TimeOnly(15, 0, 0), new TimeOnly(9, 0, 0), 5, "Friday", 5 },
                    { 6, new TimeOnly(17, 0, 0), new TimeOnly(10, 0, 0), 6, "Saturday", 6 },
                    { 7, new TimeOnly(20, 0, 0), new TimeOnly(12, 0, 0), 7, "Sunday", 7 },
                    { 8, new TimeOnly(17, 30, 0), new TimeOnly(9, 30, 0), 8, "Monday", 8 },
                    { 9, new TimeOnly(18, 30, 0), new TimeOnly(10, 30, 0), 9, "Tuesday", 9 },
                    { 10, new TimeOnly(14, 0, 0), new TimeOnly(8, 0, 0), 10, "Wednesday", 10 },
                    { 11, new TimeOnly(21, 0, 0), new TimeOnly(13, 0, 0), 11, "Thursday", 11 },
                    { 12, new TimeOnly(13, 0, 0), new TimeOnly(9, 0, 0), 12, "Friday", 12 },
                    { 13, new TimeOnly(16, 0, 0), new TimeOnly(10, 0, 0), 13, "Saturday", 13 },
                    { 14, new TimeOnly(19, 0, 0), new TimeOnly(11, 0, 0), 14, "Sunday", 14 },
                    { 15, new TimeOnly(15, 30, 0), new TimeOnly(8, 30, 0), 15, "Monday", 15 },
                    { 16, new TimeOnly(17, 30, 0), new TimeOnly(9, 30, 0), 16, "Tuesday", 16 },
                    { 17, new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0), 17, "Wednesday", 17 },
                    { 18, new TimeOnly(20, 0, 0), new TimeOnly(12, 0, 0), 18, "Thursday", 18 },
                    { 19, new TimeOnly(14, 0, 0), new TimeOnly(9, 0, 0), 19, "Friday", 19 },
                    { 20, new TimeOnly(19, 0, 0), new TimeOnly(11, 0, 0), 20, "Saturday", 20 },
                    { 21, new TimeOnly(16, 0, 0), new TimeOnly(10, 0, 0), 21, "Sunday", 21 },
                    { 22, new TimeOnly(15, 0, 0), new TimeOnly(8, 0, 0), 22, "Monday", 22 },
                    { 23, new TimeOnly(17, 0, 0), new TimeOnly(9, 0, 0), 23, "Tuesday", 23 },
                    { 24, new TimeOnly(21, 0, 0), new TimeOnly(13, 0, 0), 24, "Wednesday", 24 },
                    { 25, new TimeOnly(18, 30, 0), new TimeOnly(10, 30, 0), 25, "Thursday", 25 },
                    { 26, new TimeOnly(14, 30, 0), new TimeOnly(8, 30, 0), 26, "Friday", 26 },
                    { 27, new TimeOnly(17, 0, 0), new TimeOnly(9, 0, 0), 27, "Saturday", 27 },
                    { 28, new TimeOnly(18, 0, 0), new TimeOnly(12, 0, 0), 28, "Sunday", 28 },
                    { 29, new TimeOnly(19, 0, 0), new TimeOnly(11, 0, 0), 29, "Monday", 29 },
                    { 30, new TimeOnly(16, 0, 0), new TimeOnly(10, 0, 0), 30, "Tuesday", 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DoctorAvailabilities",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
