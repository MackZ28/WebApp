using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class bugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("Category", "id", 3, "desc", "Акустическая гитара");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
 