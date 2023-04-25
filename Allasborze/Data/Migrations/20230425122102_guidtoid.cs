using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allasborze.Data.Migrations
{
    /// <inheritdoc />
    public partial class guidtoid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Allasok",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Allasok",
                newName: "Guid");
        }
    }
}
