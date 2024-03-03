using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class authırrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

          migrationBuilder.CreateIndex(
                name: "IX_Authors_AppRoleId",
                table: "Authors",
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_AppRoles_AppRoleId",
                table: "Authors",
                column: "AppRoleId",
                principalTable: "AppRoles",
                principalColumn: "AppRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_AppRoles_AppRoleId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_AppRoleId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Authors");
        }
    }
}
