using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Web.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkingExperience_Employees_EmployeeId",
                table: "WorkingExperience");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "WorkingExperience",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "WorkingExperienceId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkingExperience_Employees_EmployeeId",
                table: "WorkingExperience",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkingExperience_Employees_EmployeeId",
                table: "WorkingExperience");

            migrationBuilder.DropColumn(
                name: "WorkingExperienceId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "WorkingExperience",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkingExperience_Employees_EmployeeId",
                table: "WorkingExperience",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
