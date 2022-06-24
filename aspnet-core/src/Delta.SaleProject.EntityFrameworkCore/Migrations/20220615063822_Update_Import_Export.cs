using Microsoft.EntityFrameworkCore.Migrations;

namespace Delta.SaleProject.Migrations
{
    public partial class Update_Import_Export : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportExportStocks_Employees_EmployeeId",
                table: "ImportExportStocks");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "ImportExportStocks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportExportStocks_Employees_EmployeeId",
                table: "ImportExportStocks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportExportStocks_Employees_EmployeeId",
                table: "ImportExportStocks");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "ImportExportStocks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportExportStocks_Employees_EmployeeId",
                table: "ImportExportStocks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
