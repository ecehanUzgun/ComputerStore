using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ComputerMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Anakartlar_AnakartId",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_ComputerMonitors_ComputerMonitorID",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_EkranKartlari_EkranKartiId",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Islemciler_IslemciId",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Klavyeler_KlavyeId",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Mice_MouseId",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Rams_RamId",
                table: "Computer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Computer",
                table: "Computer");

            migrationBuilder.RenameTable(
                name: "Computer",
                newName: "Computers");

            migrationBuilder.RenameIndex(
                name: "IX_Computer_RamId",
                table: "Computers",
                newName: "IX_Computers_RamId");

            migrationBuilder.RenameIndex(
                name: "IX_Computer_MouseId",
                table: "Computers",
                newName: "IX_Computers_MouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Computer_KlavyeId",
                table: "Computers",
                newName: "IX_Computers_KlavyeId");

            migrationBuilder.RenameIndex(
                name: "IX_Computer_IslemciId",
                table: "Computers",
                newName: "IX_Computers_IslemciId");

            migrationBuilder.RenameIndex(
                name: "IX_Computer_EkranKartiId",
                table: "Computers",
                newName: "IX_Computers_EkranKartiId");

            migrationBuilder.RenameIndex(
                name: "IX_Computer_ComputerMonitorID",
                table: "Computers",
                newName: "IX_Computers_ComputerMonitorID");

            migrationBuilder.RenameIndex(
                name: "IX_Computer_AnakartId",
                table: "Computers",
                newName: "IX_Computers_AnakartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Computers",
                table: "Computers",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_Anakartlar_AnakartId",
                table: "Computers",
                column: "AnakartId",
                principalTable: "Anakartlar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_ComputerMonitors_ComputerMonitorID",
                table: "Computers",
                column: "ComputerMonitorID",
                principalTable: "ComputerMonitors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_EkranKartlari_EkranKartiId",
                table: "Computers",
                column: "EkranKartiId",
                principalTable: "EkranKartlari",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_Islemciler_IslemciId",
                table: "Computers",
                column: "IslemciId",
                principalTable: "Islemciler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_Klavyeler_KlavyeId",
                table: "Computers",
                column: "KlavyeId",
                principalTable: "Klavyeler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_Mice_MouseId",
                table: "Computers",
                column: "MouseId",
                principalTable: "Mice",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_Rams_RamId",
                table: "Computers",
                column: "RamId",
                principalTable: "Rams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computers_Anakartlar_AnakartId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_ComputerMonitors_ComputerMonitorID",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_EkranKartlari_EkranKartiId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_Islemciler_IslemciId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_Klavyeler_KlavyeId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_Mice_MouseId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_Computers_Rams_RamId",
                table: "Computers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Computers",
                table: "Computers");

            migrationBuilder.RenameTable(
                name: "Computers",
                newName: "Computer");

            migrationBuilder.RenameIndex(
                name: "IX_Computers_RamId",
                table: "Computer",
                newName: "IX_Computer_RamId");

            migrationBuilder.RenameIndex(
                name: "IX_Computers_MouseId",
                table: "Computer",
                newName: "IX_Computer_MouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Computers_KlavyeId",
                table: "Computer",
                newName: "IX_Computer_KlavyeId");

            migrationBuilder.RenameIndex(
                name: "IX_Computers_IslemciId",
                table: "Computer",
                newName: "IX_Computer_IslemciId");

            migrationBuilder.RenameIndex(
                name: "IX_Computers_EkranKartiId",
                table: "Computer",
                newName: "IX_Computer_EkranKartiId");

            migrationBuilder.RenameIndex(
                name: "IX_Computers_ComputerMonitorID",
                table: "Computer",
                newName: "IX_Computer_ComputerMonitorID");

            migrationBuilder.RenameIndex(
                name: "IX_Computers_AnakartId",
                table: "Computer",
                newName: "IX_Computer_AnakartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Computer",
                table: "Computer",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Anakartlar_AnakartId",
                table: "Computer",
                column: "AnakartId",
                principalTable: "Anakartlar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_ComputerMonitors_ComputerMonitorID",
                table: "Computer",
                column: "ComputerMonitorID",
                principalTable: "ComputerMonitors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_EkranKartlari_EkranKartiId",
                table: "Computer",
                column: "EkranKartiId",
                principalTable: "EkranKartlari",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Islemciler_IslemciId",
                table: "Computer",
                column: "IslemciId",
                principalTable: "Islemciler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Klavyeler_KlavyeId",
                table: "Computer",
                column: "KlavyeId",
                principalTable: "Klavyeler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Mice_MouseId",
                table: "Computer",
                column: "MouseId",
                principalTable: "Mice",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Rams_RamId",
                table: "Computer",
                column: "RamId",
                principalTable: "Rams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
