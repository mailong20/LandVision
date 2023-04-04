using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandVisionAPI.Migrations
{
    /// <inheritdoc />
    public partial class addphanquyen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "TypeUserRole",
                columns: table => new
                {
                    TypeUserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeUserRole", x => new { x.RoleId, x.TypeUserId });
                    table.ForeignKey(
                        name: "FK_TypeUserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeUserRole_TypeUser_TypeUserId",
                        column: x => x.TypeUserId,
                        principalTable: "TypeUser",
                        principalColumn: "TypeUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypeUserRole_TypeUserId",
                table: "TypeUserRole",
                column: "TypeUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TypeUserRole");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
