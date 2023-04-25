using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allasborze.Data.Migrations
{
    /// <inheritdoc />
    public partial class allasokalap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allasok",
                columns: table => new
                {
                    Guid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Oraber = table.Column<int>(type: "int", nullable: false),
                    Pozicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allasok", x => x.Guid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allasok");
        }
    }
}
