using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Depi_WinForm.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationOneToManyBetweenInstructorAndDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Departments_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager",
                principalTable: "Instructors",
                principalColumn: "InsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Dept_Manager",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Dept_Manager",
                table: "Departments");
        }
    }
}
