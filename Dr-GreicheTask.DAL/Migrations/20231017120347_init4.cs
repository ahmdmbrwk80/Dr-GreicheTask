using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dr_GreicheTask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
     name: "IX_InsurancePapers_EmployeeId",
     table: "InsurancePapers");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
