using Microsoft.EntityFrameworkCore.Migrations;

namespace NewProj.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    DealId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DealName = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.DealId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deals");
        }
    }
}
