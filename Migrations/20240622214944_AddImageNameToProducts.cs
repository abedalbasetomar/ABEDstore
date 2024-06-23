using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABEDstore.Migrations
{
    /// <inheritdoc />
    public partial class AddImageNameToProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Pruducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Pruducts");
        }
    }
}
