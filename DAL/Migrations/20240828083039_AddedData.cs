using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedData : Migration
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

            migrationBuilder.RenameColumn(
                name: "Kablolu",
                table: "Mice",
                newName: "IsWireless");

            migrationBuilder.RenameColumn(
                name: "Kablolu",
                table: "Klavyeler",
                newName: "IsWireless");

            migrationBuilder.AddColumn<double>(
                name: "ClockSpeed",
                table: "Islemciler",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "CoreCount",
                table: "Islemciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemorySize",
                table: "EkranKartlari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Anakartlar",
                columns: new[] { "ID", "Brand", "KdvRate", "Model", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Asus", 18m, "ROG Strix B550-F", 10, 2000m },
                    { 2, "MSI", 18m, "MAG B550 TOMAHAWK", 15, 1850.75m }
                });

            migrationBuilder.InsertData(
                table: "ComputerMonitors",
                columns: new[] { "ID", "Brand", "KdvRate", "Model", "Quantity", "Size", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Dell", 10m, "UltraSharp U2720Q", 8, 27, 4500.99m },
                    { 2, "Samsung", 10m, "Odyssey G7", 5, 32, 5500.75m }
                });

            migrationBuilder.InsertData(
                table: "EkranKartlari",
                columns: new[] { "ID", "Brand", "KdvRate", "MemorySize", "Model", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "NVIDIA", 18m, 0, "GeForce RTX 3080", 7, 12000.00m },
                    { 2, "AMD", 18m, 16, "Radeon RX 6800 XT", 5, 11000.50m }
                });

            migrationBuilder.InsertData(
                table: "Islemciler",
                columns: new[] { "ID", "Brand", "ClockSpeed", "CoreCount", "KdvRate", "Model", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Intel", 3.5, 8, 18m, "Core i9-11900K", 12, 7000m },
                    { 2, "AMD", 3.3999999999999999, 16, 10m, "Ryzen 9 5950X", 10, 8500.50m }
                });

            migrationBuilder.InsertData(
                table: "Klavyeler",
                columns: new[] { "ID", "Brand", "IsWireless", "KdvRate", "Model", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Logitech", false, 0m, "G Pro X", 20, 1200.50m },
                    { 2, "Razer", true, 18m, "BlackWidow V3 Pro", 15, 1500.75m }
                });

            migrationBuilder.InsertData(
                table: "Mice",
                columns: new[] { "ID", "Brand", "IsSilentTouch", "IsWireless", "KdvRate", "Model", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Logitech", false, false, 18m, "G502 HERO", 25, 450.99m },
                    { 2, "Razer", true, true, 18m, "DeathAdder V2 Pro", 18, 750.50m }
                });

            migrationBuilder.InsertData(
                table: "Rams",
                columns: new[] { "ID", "Brand", "Capacity", "KdvRate", "Model", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Corsair", 16, 18m, "Vengeance LPX", 30, 1200m },
                    { 2, "G.Skill", 32, 10m, "Trident Z RGB", 20, 1500.50m }
                });

            migrationBuilder.InsertData(
                table: "SSDs",
                columns: new[] { "ID", "Brand", "Capacity", "KdvRate", "Model", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Samsung", 1000, 18m, "970 EVO Plus", 15, 2000m },
                    { 2, "Western Digital", 2000, 10m, "WD Black SN850", 10, 2500.75m }
                });

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

            migrationBuilder.DeleteData(
                table: "Anakartlar",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Anakartlar",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ComputerMonitors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComputerMonitors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EkranKartlari",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EkranKartlari",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Islemciler",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Islemciler",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Klavyeler",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Klavyeler",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mice",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mice",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SSDs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SSDs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ClockSpeed",
                table: "Islemciler");

            migrationBuilder.DropColumn(
                name: "CoreCount",
                table: "Islemciler");

            migrationBuilder.DropColumn(
                name: "MemorySize",
                table: "EkranKartlari");

            migrationBuilder.RenameColumn(
                name: "IsWireless",
                table: "Mice",
                newName: "Kablolu");

            migrationBuilder.RenameColumn(
                name: "IsWireless",
                table: "Klavyeler",
                newName: "Kablolu");

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
