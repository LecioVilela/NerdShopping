using Microsoft.EntityFrameworkCore.Migrations;

namespace NerdShopping.API.Migrations
{
    public partial class AddProductDataTableOnDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tab_product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    vl_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    des_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    des_category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    image_url = table.Column<string>(name: "image_ url", type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_product", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tab_product");
        }
    }
}
