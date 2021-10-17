using Microsoft.EntityFrameworkCore.Migrations;

namespace UofLMentorshipProgram.Migrations
{
    public partial class UserTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Pay",
                table: "JobPostings",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pay",
                table: "JobPostings");
        }
    }
}
