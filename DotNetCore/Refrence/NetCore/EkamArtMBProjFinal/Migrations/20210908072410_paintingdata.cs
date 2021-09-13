using Microsoft.EntityFrameworkCore.Migrations;

namespace EkamArtMBProj.Migrations
{
    public partial class paintingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "PaintingId", "CareInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPaintingOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 4, null, 2, "/images/Greece.jpg", "/images/Greece.jpg", true, true, "A Beautiful painting that can enhance your home space!", "Greece Magic", 8500m, "Lorem Ipsum" },
                    { 5, null, 2, "/images/boat.jpeg", "/images/boat.jpeg", true, true, "A Beautiful painting that can enhance your home space!", "Sunset Skies", 19500m, "Lorem Ipsum" },
                    { 6, null, 1, "/images/Sunflowers.png", "/images/Sunflowers.png", true, true, "A Beautiful painting that can enhance your home space!", "Sunriched", 12000m, "Lorem Ipsum" },
                    { 7, null, 1, "/images/lotus3.png", "/images/lotus3.jpg", true, true, "A Beautiful painting that can enhance your home space!", "Bloom", 12000m, "Lorem Ipsum" },
                    { 8, null, 1, "/images/Lilly.png", "/images/Lilly.png", true, true, "A Beautiful painting that can enhance your home space!", "Bloom again", 12000m, "Lorem Ipsum" },
                    { 9, null, 1, "/images/peacock3.jpeg", "/images/peacock3.jpeg", true, false, "A Beautiful painting that can enhance your home space!", "Blue Beauty", 12000m, "Lorem Ipsum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PaintingId",
                keyValue: 9);
        }
    }
}
