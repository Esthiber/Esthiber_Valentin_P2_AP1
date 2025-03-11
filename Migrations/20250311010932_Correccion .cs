using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthiber_Valentin_P2_AP1.Migrations
{
    /// <inheritdoc />
    public partial class Correccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailsEncuestas_Ciudades_CiudadId",
                table: "DetailsEncuestas");

            migrationBuilder.DropIndex(
                name: "IX_DetailsEncuestas_CiudadId",
                table: "DetailsEncuestas");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "DetailsEncuestas");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsEncuestas_CuidadId",
                table: "DetailsEncuestas",
                column: "CuidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsEncuestas_Ciudades_CuidadId",
                table: "DetailsEncuestas",
                column: "CuidadId",
                principalTable: "Ciudades",
                principalColumn: "CiudadId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailsEncuestas_Ciudades_CuidadId",
                table: "DetailsEncuestas");

            migrationBuilder.DropIndex(
                name: "IX_DetailsEncuestas_CuidadId",
                table: "DetailsEncuestas");

            migrationBuilder.AddColumn<int>(
                name: "CiudadId",
                table: "DetailsEncuestas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetailsEncuestas_CiudadId",
                table: "DetailsEncuestas",
                column: "CiudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsEncuestas_Ciudades_CiudadId",
                table: "DetailsEncuestas",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "CiudadId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
