using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission5_ear69.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: false),
                    Edit = table.Column<bool>(type: "INTEGER", nullable: false),
                    Lent = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Comedy", "Seth Rogen/EvenGoldberg", false, "no", "Funny film", "R", "This is the End", 2013 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Drama", "Robert Eggers", false, "no", "Willem Dafoe is the best actor", "R", "LightHouse", 2019 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Drama", "Daniel Brothers", false, "no", "The best movie ever made", "R", "Everything Everywhere All At Once", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
