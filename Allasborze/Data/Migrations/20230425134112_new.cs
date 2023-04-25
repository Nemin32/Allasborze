using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allasborze.Data.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllasModelAllasUser",
                columns: table => new
                {
                    AllasModelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DolgozokId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllasModelAllasUser", x => new { x.AllasModelId, x.DolgozokId });
                    table.ForeignKey(
                        name: "FK_AllasModelAllasUser_Allasok_AllasModelId",
                        column: x => x.AllasModelId,
                        principalTable: "Allasok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllasModelAllasUser_AspNetUsers_DolgozokId",
                        column: x => x.DolgozokId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllasModelAllasUser1",
                columns: table => new
                {
                    AllasUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AllasokId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllasModelAllasUser1", x => new { x.AllasUserId, x.AllasokId });
                    table.ForeignKey(
                        name: "FK_AllasModelAllasUser1_Allasok_AllasokId",
                        column: x => x.AllasokId,
                        principalTable: "Allasok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllasModelAllasUser1_AspNetUsers_AllasUserId",
                        column: x => x.AllasUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllasModelAllasUser_DolgozokId",
                table: "AllasModelAllasUser",
                column: "DolgozokId");

            migrationBuilder.CreateIndex(
                name: "IX_AllasModelAllasUser1_AllasokId",
                table: "AllasModelAllasUser1",
                column: "AllasokId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllasModelAllasUser");

            migrationBuilder.DropTable(
                name: "AllasModelAllasUser1");
        }
    }
}
