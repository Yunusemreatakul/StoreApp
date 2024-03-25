using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Telefon", "Akıllı Telefon", "Samsung s16", 25000m },
                    { 2, "Telefon", "Baya Akıllı Telefon", "Samsung s17", 26000m },
                    { 3, "Telefon", "Çok Akıllı Telefon", "Samsung s18", 27000m },
                    { 4, "Telefon", "En Akıllı Telefon", "Samsung s19", 28000m },
                    { 5, "Telefon", "En En Akıllı Telefon", "Samsung s20", 29000m },
                    { 6, "Telefon", "Senden Akıllı Telefon", "Samsung s21", 30000m },
                    { 7, "Telefon", "yeni model Akıllı Telefon", "Samsung s22", 31000m },
                    { 8, "Telefon", "Inanılmaz zeki ve Akıllı Telefon", "Samsung s23", 32000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
