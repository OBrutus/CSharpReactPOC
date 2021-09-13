using Microsoft.EntityFrameworkCore.Migrations;

namespace EkamArtMBProj.Migrations
{
    public partial class paintingdata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/Lilly.jpg", "/images/Lilly.jpg" });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/peacock2.jpeg", "/images/peacock2.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/Lilly.png", "/images/Lilly.png" });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/peacock3.jpeg", "/images/peacock3.jpeg" });
        }
    }
}
