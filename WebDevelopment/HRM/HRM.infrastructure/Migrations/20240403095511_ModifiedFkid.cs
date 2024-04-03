using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Web.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedFkid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkingExperienceId",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkingExperienceId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
