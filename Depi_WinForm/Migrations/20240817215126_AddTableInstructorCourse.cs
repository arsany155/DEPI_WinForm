using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Depi_WinForm.Migrations
{
    /// <inheritdoc />
    public partial class AddTableInstructorCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructor_Courses",
                columns: table => new
                {
                    InsId = table.Column<int>(type: "int", nullable: false),
                    CrsId = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor_Courses", x => new { x.CrsId, x.InsId });
                    table.ForeignKey(
                        name: "FK_Instructor_Courses_Courses_CrsId",
                        column: x => x.CrsId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructor_Courses_Instructors_InsId",
                        column: x => x.InsId,
                        principalTable: "Instructors",
                        principalColumn: "InsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Courses_InsId",
                table: "Instructor_Courses",
                column: "InsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructor_Courses");
        }
    }
}
