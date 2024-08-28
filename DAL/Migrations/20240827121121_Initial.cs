using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computers_ComputerMonitors_ComputerMonitorID",
                table: "Computers");

            migrationBuilder.DropIndex(
                name: "IX_Computers_ComputerMonitorID",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "ComputerMonitorID",
                table: "Computers");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_MonitorId",
                table: "Computers",
                column: "MonitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_ComputerMonitors_MonitorId",
                table: "Computers",
                column: "MonitorId",
                principalTable: "ComputerMonitors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computers_ComputerMonitors_MonitorId",
                table: "Computers");

            migrationBuilder.DropIndex(
                name: "IX_Computers_MonitorId",
                table: "Computers");

            migrationBuilder.AddColumn<int>(
                name: "ComputerMonitorID",
                table: "Computers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Computers_ComputerMonitorID",
                table: "Computers",
                column: "ComputerMonitorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_ComputerMonitors_ComputerMonitorID",
                table: "Computers",
                column: "ComputerMonitorID",
                principalTable: "ComputerMonitors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
