using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prog2bPOE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    LecturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursWorked = table.Column<int>(type: "int", nullable: false),
                    HourlyRate = table.Column<double>(type: "float", nullable: false),
                    TotalHours = table.Column<double>(type: "float", nullable: false),
                    AddNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.LecturerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");
        }
    }
}
