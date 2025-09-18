using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamBoard.Migrations
{
    /// <inheritdoc />
    public partial class addExamTrigger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create trigger
            migrationBuilder.Sql(@"
                CREATE TRIGGER TR_DeleteExamWithoutQuestions
                ON Questions
                AFTER DELETE
                AS
                BEGIN
                    DELETE FROM Exams
                    WHERE Id IN (
                        SELECT e.Id
                        FROM Exams e
                        LEFT JOIN ExamQuestions eq ON e.Id = eq.ExamId
                        GROUP BY e.Id
                        HAVING COUNT(eq.QuestionId) = 0
                    );
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop trigger if rolling back
            migrationBuilder.Sql(@"DROP TRIGGER IF EXISTS TR_DeleteExamWithoutQuestions;");
        }
    }
}
