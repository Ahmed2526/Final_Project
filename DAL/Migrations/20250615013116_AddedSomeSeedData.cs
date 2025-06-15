using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedSomeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "About", "Email", "FirstName", "LastName", "Password", "Phone", "ProfilePic", "Rate", "SpecialityId" },
                values: new object[,]
                {
                    { 1, "Dr. Ahmed Samir is a seasoned cardiologist with over 15 years of experience. He is well-known for his expertise in treating complex heart conditions and his dedication to preventative care.", "ahmed.samir@example.com", "Ahmed", "Samir", "hashedpassword1", "01012345678", null, 4.5999999999999996, 1 },
                    { 2, "Dr. Nour Hassan is a passionate pediatrician who excels in creating a friendly and comfortable environment for children while providing high-quality medical care.", "nour.hassan@example.com", "Nour", "Hassan", "hashedpassword2", "01123456789", null, 4.7000000000000002, 2 },
                    { 3, "Dr. Youssef Mahmoud is a general surgeon with vast experience in minimally invasive surgical techniques and postoperative care.", "youssef.mahmoud@example.com", "Youssef", "Mahmoud", "hashedpassword3", "01234567890", null, 4.7999999999999998, 3 },
                    { 4, "Dr. Fatma Amin is a skilled dermatologist who specializes in treating chronic skin conditions and offers a blend of clinical and aesthetic dermatology.", "fatma.amin@example.com", "Fatma", "Amin", "hashedpassword4", "01587654321", null, 4.2999999999999998, 4 },
                    { 5, "Dr. Omar Hassan is a neurologist with deep expertise in treating epilepsy, migraines, and nervous system disorders. He provides comprehensive evaluations and long-term management plans.", "omar.hassan@example.com", "Omar", "Hassan", "hashedpassword5", "01098765432", null, 4.2000000000000002, 5 },
                    { 6, "Dr. Salma Mostafa is a gynecologist who focuses on women's health and reproductive issues. She is widely respected for her compassionate approach and surgical skill.", "salma.mostafa@example.com", "Salma", "Mostafa", "hashedpassword6", "01155667718", null, 4.4000000000000004, 6 },
                    { 7, "Dr. Mohamed Adel is an orthopedic surgeon with a focus on joint replacement and sports injuries. He’s known for helping patients regain mobility with effective treatments.", "mohamed.adel@example.com", "Mohamed", "Adel", "hashedpassword7", "01266778199", null, 4.5, 7 },
                    { 8, "Dr. Rania Saad is an internist providing expert care in chronic conditions such as diabetes, hypertension, and gastrointestinal diseases.", "rania.saad@example.com", "Rania", "Saad", "hashedpassword8", "01599887766", null, 4.0999999999999996, 8 },
                    { 9, "Dr. Hossam Yehia is a psychiatrist with a strong reputation in treating mood and anxiety disorders through both therapy and medication.", "hossam.yehia@example.com", "Hossam", "Yehia", "hashedpassword9", "01022334455", null, 4.0, 9 },
                    { 10, "Dr. Dina Ibrahim is an ophthalmologist skilled in laser eye surgery and glaucoma management. Her detail-oriented care has helped many regain vision.", "dina.ibrahim@example.com", "Dina", "Ibrahim", "hashedpassword10", "01144556677", null, 4.9000000000000004, 10 },
                    { 11, "Dr. Ali Khaled is an ENT specialist who offers comprehensive care for sinus disorders, hearing loss, and voice disorders.", "ali.khaled@example.com", "Ali", "Khaled", "hashedpassword11", "01233445566", null, 4.2999999999999998, 11 },
                    { 12, "Dr. Nada Zaki is a clinical pathologist with a keen interest in hematology and diagnostics. She ensures precise and timely lab results for better diagnosis.", "nada.zaki@example.com", "Nada", "Zaki", "hashedpassword12", "01511223344", null, 4.5999999999999996, 12 },
                    { 13, "Dr. Karim Osman is an endocrinologist specializing in thyroid disorders, diabetes, and metabolic conditions. He combines technology and personal care.", "karim.osman@example.com", "Karim", "Osman", "hashedpassword13", "01033445566", null, 4.7000000000000002, 13 },
                    { 14, "Dr. Layla Nasser is a rheumatologist with extensive experience in treating autoimmune diseases such as lupus and rheumatoid arthritis.", "layla.nasser@example.com", "Layla", "Nasser", "hashedpassword14", "01199887766", null, 4.7999999999999998, 14 },
                    { 15, "Dr. Tamer ElSayed is a nephrologist who manages patients with kidney failure and provides dialysis care in both acute and chronic settings.", "tamer.elsayed@example.com", "Tamer", "ElSayed", "hashedpassword15", "01277889900", null, 4.5, 15 },
                    { 16, "Dr. Maha Amer is a hematologist with a strong research background in anemia and leukemia. She provides cutting-edge care in a supportive environment.", "maha.amer@example.com", "Maha", "Amer", "hashedpassword16", "01533445577", null, 4.9000000000000004, 16 },
                    { 17, "Dr. Ehab Hafez is a gastroenterologist known for his advanced colonoscopy techniques and management of IBS and liver disorders.", "ehab.hafez@example.com", "Ehab", "Hafez", "hashedpassword17", "01044556677", null, 4.4000000000000004, 17 },
                    { 18, "Dr. Rana Ashraf is a general practitioner with over 12 years of experience in family medicine, preventive care, and health education.", "rana.ashraf@example.com", "Rana", "Ashraf", "hashedpassword18", "01155667788", null, 4.2999999999999998, 18 },
                    { 19, "Dr. Mostafa Selim is a pulmonologist who helps patients with asthma, COPD, and chronic bronchitis breathe easier with modern therapies.", "mostafa.selim@example.com", "Mostafa", "Selim", "hashedpassword19", "01266778899", null, 4.2000000000000002, 19 },
                    { 20, "Dr. Reem Abdelrahman is an oncologist providing chemotherapy and personalized cancer care. She builds lasting relationships with her patients.", "reem.abdelrahman@example.com", "Reem", "Abdelrahman", "hashedpassword20", "01577889900", null, 4.5999999999999996, 20 },
                    { 21, "Dr. Alyaa Mansour is a radiologist with exceptional interpretation skills in MRI, CT, and ultrasound. Her quick turnaround time is highly valued.", "alyaa.mansour@example.com", "Alyaa", "Mansour", "hashedpassword21", "01099887766", null, 4.4000000000000004, 21 },
                    { 22, "Dr. Hany Tawfik is an anesthesiologist experienced in surgical and ICU care. His calm presence reassures patients before and during procedures.", "hany.tawfik@example.com", "Hany", "Tawfik", "hashedpassword22", "01188776655", null, 4.7000000000000002, 22 },
                    { 23, "Dr. Ghada Ali is a dental surgeon offering cosmetic and reconstructive dental solutions using the latest techniques and technology.", "ghada.ali@example.com", "Ghada", "Ali", "hashedpassword23", "01233445599", null, 4.5, 23 },
                    { 24, "Dr. Walid Gamal is a urologist specializing in kidney stone treatment and male reproductive health. He is known for his professionalism and results.", "walid.gamal@example.com", "Walid", "Gamal", "hashedpassword24", "01599887711", null, 4.5999999999999996, 24 },
                    { 25, "Dr. Nadine Hisham is a plastic surgeon delivering both aesthetic and reconstructive solutions tailored to each patient’s needs and desires.", "nadine.hisham@example.com", "Nadine", "Hisham", "hashedpassword25", "01033445588", null, 4.7000000000000002, 25 },
                    { 26, "Dr. Ayman Fathy is a vascular surgeon who treats arterial and venous diseases with minimally invasive procedures.", "ayman.fathy@example.com", "Ayman", "Fathy", "hashedpassword26", "01144557766", null, 4.7999999999999998, 26 },
                    { 27, "Dr. Samah Ragab is a fertility specialist offering IVF, hormonal therapies, and personalized reproductive plans for couples.", "samah.ragab@example.com", "Samah", "Ragab", "hashedpassword27", "01222334455", null, 4.2999999999999998, 27 },
                    { 28, "Dr. Mahmoud Salem is an experienced general practitioner offering whole-person care and long-term patient relationships.", "mahmoud.salem@example.com", "Mahmoud", "Salem", "hashedpassword28", "01522334455", null, 4.5999999999999996, 5 },
                    { 29, "Dr. Marwa Ashour is a dedicated pediatrician who believes in family-focused care and child development education.", "marwa.ashour@example.com", "Marwa", "Ashour", "hashedpassword29", "01066778899", null, 4.4000000000000004, 6 },
                    { 30, "Dr. Sherif Tarek is a critical care specialist leading ICU teams with a focus on survival, stabilization, and long-term outcomes.", "sherif.tarek@example.com", "Sherif", "Tarek", "hashedpassword30", "01122334455", null, 4.9000000000000004, 7 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CityId", "GovernateId", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, 1, 1, "10023", "45 Talaat Harb St." },
                    { 2, 9, 2, "10154", "88 Kasr El Nile St." },
                    { 3, 12, 3, "10276", "29 Abbas El Akkad St." },
                    { 4, 16, 4, "10322", "77 El Nasr Rd." },
                    { 5, 19, 5, "10498", "15 El Merghany St." },
                    { 6, 22, 6, "10531", "61 Al Haram St." },
                    { 7, 25, 7, "10647", "94 Faisal St." },
                    { 8, 28, 8, "10782", "36 October 6th St." },
                    { 9, 31, 9, "10859", "103 Ahmed Orabi St." },
                    { 10, 34, 10, "10964", "20 Sudan St." },
                    { 11, 37, 11, "11035", "11 Shubra St." },
                    { 12, 38, 11, "11109", "81 Ain Shams St." },
                    { 13, 40, 12, "11243", "38 Al Moqatam St." },
                    { 14, 41, 12, "11356", "52 Naguib Mahfouz St." },
                    { 15, 4, 1, "11477", "66 El Hegaz St." },
                    { 16, 5, 1, "11588", "91 Salah Salem St." },
                    { 17, 6, 1, "11642", "27 El Khalifa El Maamoun St." },
                    { 18, 13, 3, "11793", "74 Al Azhar St." },
                    { 19, 14, 3, "11834", "59 Mohamed Mahmoud St." },
                    { 20, 17, 4, "11921", "35 Al Mokattam Corniche" },
                    { 21, 18, 4, "12015", "14 Saad Zaghloul St." },
                    { 22, 20, 5, "12126", "109 Al Nozha St." },
                    { 23, 21, 5, "12274", "63 Makram Ebeid St." },
                    { 24, 23, 6, "12333", "79 El Orouba St." },
                    { 25, 24, 6, "12488", "32 Cleopatra St." },
                    { 26, 27, 7, "12577", "48 Al Thawra St." },
                    { 27, 28, 8, "12644", "17 Al Montazah St." },
                    { 28, 2, 1, "12753", "70 Ramses St." },
                    { 29, 3, 1, "12819", "97 Gomhoria St." },
                    { 30, 8, 2, "12902", "22 Port Said St." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
