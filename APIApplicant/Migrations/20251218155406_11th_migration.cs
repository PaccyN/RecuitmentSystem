using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIApplicant.Migrations
{
    /// <inheritdoc />
    public partial class _11th_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Interview",
                table: "Interview");

            migrationBuilder.RenameTable(
                name: "Interview",
                newName: "Interviews");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interviews",
                table: "Interviews",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Interviews",
                table: "Interviews");

            migrationBuilder.RenameTable(
                name: "Interviews",
                newName: "Interview");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interview",
                table: "Interview",
                column: "Id");
        }
    }
}
