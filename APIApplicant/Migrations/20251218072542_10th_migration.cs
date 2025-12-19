using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIApplicant.Migrations
{
    /// <inheritdoc />
    public partial class _10th_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFrom",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "DateTo",
                table: "Interview");

            migrationBuilder.AddColumn<DateOnly>(
                name: "InterviewDate",
                table: "Interview",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "TimeFrom",
                table: "Interview",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "TimeTo",
                table: "Interview",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InterviewDate",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "TimeFrom",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "TimeTo",
                table: "Interview");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFrom",
                table: "Interview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTo",
                table: "Interview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
