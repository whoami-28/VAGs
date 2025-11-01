using Microsoft.EntityFrameworkCore.Migrations;

namespace VAGFabrick.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AUDI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    TankVolume = table.Column<int>(nullable: false),
                    CarCase = table.Column<string>(nullable: true),
                    FuelQuantity = table.Column<double>(nullable: false),
                    FuelConsumption = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Volkswagen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    TankVolume = table.Column<int>(nullable: false),
                    CarCase = table.Column<string>(nullable: true),
                    FuelQuantity = table.Column<double>(nullable: false),
                    FuelConsumption = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volkswagen", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AUDI");

            migrationBuilder.DropTable(
                name: "Volkswagen");
        }
    }
}
