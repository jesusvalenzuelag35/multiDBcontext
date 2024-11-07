using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccesoDatos.Migrations.TalleresDB
{
    /// <inheritdoc />
    public partial class terceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employee_CompanyId",
                table: "employee",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_ID",
                table: "employee",
                column: "CompanyId",
                principalTable: "company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_ID",
                table: "employee");

            migrationBuilder.DropIndex(
                name: "IX_employee_CompanyId",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "employee");
        }
    }
}
