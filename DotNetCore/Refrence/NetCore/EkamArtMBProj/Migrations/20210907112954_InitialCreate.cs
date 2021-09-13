using Microsoft.EntityFrameworkCore.Migrations;

namespace EkamArtMBProj.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Paintings",
                columns: table => new
                {
                    PaintingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPaintingOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paintings", x => x.PaintingId);
                    table.ForeignKey(
                        name: "FK_Paintings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Watercolor", "The most versatile and fresh medium" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Acrylic", "The most versatile and fresh medium" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Gouache", "The most versatile and fresh medium" });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "PaintingId", "CareInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPaintingOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, null, 1, "/images/Alley.jpg", "/images/Alley.jpg", true, false, "A Beautiful painting that can enhance your home space!", "Diagon Alley", 15000m, "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "PaintingId", "CareInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPaintingOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, null, 2, "/images/saadhu.jpg", "/images/saadhu.jpg", true, false, "A Beautiful painting that can enhance your home space!", "Portrait of a Sadhu", 10000m, "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "PaintingId", "CareInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPaintingOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, null, 3, "/images/Well.jpg", "/images/Well.jpg", true, false, "A Beautiful painting that can enhance your home space!", "Stairway to Heaven", 20000m, "Lorem Ipsum" });

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_CategoryId",
                table: "Paintings",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paintings");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
