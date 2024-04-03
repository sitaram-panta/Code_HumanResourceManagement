using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Web.Migrations
{
    /// <inheritdoc />
    public partial class deletedtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkedProject");

            migrationBuilder.DropTable(
                name: "WorkingExperience");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkingExperience",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkingExperience_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkedProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkingExperienceId = table.Column<int>(type: "int", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkedProject_WorkingExperience_WorkingExperienceId",
                        column: x => x.WorkingExperienceId,
                        principalTable: "WorkingExperience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkedProject_WorkingExperienceId",
                table: "WorkedProject",
                column: "WorkingExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkingExperience_EmployeeId",
                table: "WorkingExperience",
                column: "EmployeeId");
        }
    }
}
