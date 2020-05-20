using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesDAL.Migrations
{
    public partial class Lab29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, "Comedy", "Shrek" },
                    { 2, "Action", "James Bond" },
                    { 3, "Fantasy", "Lord of the Rings" },
                    { 4, "Science Fiction", "Star Wars" },
                    { 5, "Science Fiction", "Star Trek" },
                    { 6, "Comedy", "Austin Powers" },
                    { 7, "Action", "John Wick" },
                    { 8, "Action", "The Avengers" },
                    { 9, "Fantasy", "Willow" },
                    { 10, "Comedy", "Ace Ventura: Pet Detective" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
