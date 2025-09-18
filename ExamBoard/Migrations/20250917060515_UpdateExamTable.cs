using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamBoard.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExamTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfQuestions",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isCompleted",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfQuestions",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "isCompleted",
                table: "Exams");
        }
    }
}
