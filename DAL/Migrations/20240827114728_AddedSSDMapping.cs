using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedSSDMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SSDId",
                table: "Computers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Computers_SSDId",
                table: "Computers",
                column: "SSDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_SSDs_SSDId",
                table: "Computers",
                column: "SSDId",
                principalTable: "SSDs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computers_SSDs_SSDId",
                table: "Computers");

            migrationBuilder.DropIndex(
                name: "IX_Computers_SSDId",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "SSDId",
                table: "Computers");
        }
    }
}
