using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Downloads.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarName = table.Column<string>(type: "TEXT", nullable: true),
                    CarModel = table.Column<string>(type: "TEXT", nullable: true),
                    CarYear = table.Column<int>(type: "INTEGER", nullable: false),
                    CarGrade = table.Column<string>(type: "TEXT", nullable: true),
                    CarCost = table.Column<int>(type: "INTEGER", nullable: false),
                    CarDescription = table.Column<string>(type: "TEXT", nullable: false),
                    CarPicURL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
