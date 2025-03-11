using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthiber_Valentin_P2_AP1.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Monto",
                table: "DetailsEncuestas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Monto",
                table: "DetailsEncuestas");
        }
    }
}
