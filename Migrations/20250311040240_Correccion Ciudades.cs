using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthiber_Valentin_P2_AP1.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionCiudades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CiudadId",
                table: "DetailsEncuestas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "DetailsEncuestas");
        }
    }
}
