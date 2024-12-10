using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curiosity_Voyage_Library_Management_System_1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BooksID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Author = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PublishedYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BooksID);
                });

            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    BorrowersID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.BorrowersID);
                });

            migrationBuilder.CreateTable(
                name: "BookBorrower",
                columns: table => new
                {
                    BorrowersID = table.Column<int>(type: "INTEGER", nullable: false),
                    BooksID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBorrower", x => new { x.BooksID, x.BorrowersID });
                    table.ForeignKey(
                        name: "FK_BookBorrower_Books_BooksID",
                        column: x => x.BooksID,
                        principalTable: "Books",
                        principalColumn: "BooksID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBorrower_Borrowers_BorrowersID",
                        column: x => x.BorrowersID,
                        principalTable: "Borrowers",
                        principalColumn: "BorrowersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrower_BorrowersID",
                table: "BookBorrower",
                column: "BorrowersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBorrower");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Borrowers");
        }
    }
}
