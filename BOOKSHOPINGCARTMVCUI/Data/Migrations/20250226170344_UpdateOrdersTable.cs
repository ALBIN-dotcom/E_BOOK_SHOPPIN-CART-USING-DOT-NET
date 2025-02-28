using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOKSHOPINGCARTMVCUI.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Book");
        }
    }
}
