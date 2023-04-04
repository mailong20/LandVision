using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandVisionAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRealEstate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "User",
                newName: "IsDelete");

            migrationBuilder.CreateTable(
                name: "RealEstateType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RealEstate",
                columns: table => new
                {
                    RealEstateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentialAreaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubdivisionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedroomNumber = table.Column<int>(type: "int", nullable: false),
                    BathroomNumber = table.Column<int>(type: "int", nullable: false),
                    MainDoorDirection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorNumber = table.Column<int>(type: "int", nullable: false),
                    LegalPapers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InteriorCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasCarAlley = table.Column<bool>(type: "bit", nullable: false),
                    HasWiderBack = table.Column<bool>(type: "bit", nullable: false),
                    LandArea = table.Column<double>(type: "float", nullable: false),
                    UsableArea = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RealEstateTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstate", x => x.RealEstateId);
                    table.ForeignKey(
                        name: "FK_RealEstate_RealEstateType_RealEstateTypeId",
                        column: x => x.RealEstateTypeId,
                        principalTable: "RealEstateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RealEstate_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaLink = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RealEstateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_RealEstate_RealEstateId",
                        column: x => x.RealEstateId,
                        principalTable: "RealEstate",
                        principalColumn: "RealEstateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    RealEstateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_RealEstate_RealEstateId",
                        column: x => x.RealEstateId,
                        principalTable: "RealEstate",
                        principalColumn: "RealEstateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Media_RealEstateId",
                table: "Media",
                column: "RealEstateId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_RealEstateId",
                table: "Position",
                column: "RealEstateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_RealEstateTypeId",
                table: "RealEstate",
                column: "RealEstateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_UserId",
                table: "RealEstate",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "RealEstate");

            migrationBuilder.DropTable(
                name: "RealEstateType");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "User",
                newName: "IsActive");
        }
    }
}
