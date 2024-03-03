using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _createa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
            migrationBuilder.AddColumn<string>(
               name: "Password",
               table: "Authors",
               type: "nvarchar(max)",
               nullable: false,
               defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
          
        }
    }
}
