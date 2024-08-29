using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Depi_WinForm.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentCourseAndMakeSomeConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student_Courses",
                columns: table => new
                {
                    CrsId = table.Column<int>(type: "int", nullable: false),
                    StId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Courses", x => new { x.StId, x.CrsId });
                    table.ForeignKey(
                        name: "FK_Student_Courses_Courses_CrsId",
                        column: x => x.CrsId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Courses_Students_StId",
                        column: x => x.StId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_CrsId",
                table: "Student_Courses",
                column: "CrsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_Courses");
        }
    }
}
