using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class modified_Govs_areas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GovernateId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_GovernateId",
                table: "Cities",
                column: "GovernateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Governates_GovernateId",
                table: "Cities",
                column: "GovernateId",
                principalTable: "Governates",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Governates_GovernateId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_GovernateId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "GovernateId",
                table: "Cities");
        }
    }
}
