using Microsoft.EntityFrameworkCore.Migrations;

namespace EstanciaCaballos.App.Persistencia.Migrations
{
    public partial class Entidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caballos_Finca_fincaId",
                table: "Caballos");

            migrationBuilder.DropForeignKey(
                name: "FK_Caballos_Personas_propietarioId",
                table: "Caballos");

            migrationBuilder.DropForeignKey(
                name: "FK_Caballos_Personas_veterinarioAsignadoId",
                table: "Caballos");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosVisita_Caballos_caballoAsociadoId",
                table: "DocumentosVisita");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosVisita_Recomendaciones_recomendacionVisitaId",
                table: "DocumentosVisita");

            migrationBuilder.DropForeignKey(
                name: "FK_Historias_Caballos_caballoAsociadoId",
                table: "Historias");

            migrationBuilder.DropTable(
                name: "Finca");

            migrationBuilder.DropIndex(
                name: "IX_Historias_caballoAsociadoId",
                table: "Historias");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosVisita_caballoAsociadoId",
                table: "DocumentosVisita");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosVisita_recomendacionVisitaId",
                table: "DocumentosVisita");

            migrationBuilder.DropIndex(
                name: "IX_Caballos_fincaId",
                table: "Caballos");

            migrationBuilder.DropIndex(
                name: "IX_Caballos_propietarioId",
                table: "Caballos");

            migrationBuilder.DropIndex(
                name: "IX_Caballos_veterinarioAsignadoId",
                table: "Caballos");

            migrationBuilder.DropColumn(
                name: "caballoAsociadoId",
                table: "Historias");

            migrationBuilder.DropColumn(
                name: "caballoAsociadoId",
                table: "DocumentosVisita");

            migrationBuilder.DropColumn(
                name: "recomendacionVisitaId",
                table: "DocumentosVisita");

            migrationBuilder.DropColumn(
                name: "fincaId",
                table: "Caballos");

            migrationBuilder.DropColumn(
                name: "propietarioId",
                table: "Caballos");

            migrationBuilder.DropColumn(
                name: "veterinarioAsignadoId",
                table: "Caballos");

            migrationBuilder.AddColumn<int>(
                name: "Id_caballoAsociado",
                table: "Historias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_caballoAsociado",
                table: "DocumentosVisita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_recomendacionVisita",
                table: "DocumentosVisita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_finca",
                table: "Caballos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_propietario",
                table: "Caballos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_veterinarioAsignado",
                table: "Caballos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_caballoAsociado",
                table: "Historias");

            migrationBuilder.DropColumn(
                name: "Id_caballoAsociado",
                table: "DocumentosVisita");

            migrationBuilder.DropColumn(
                name: "Id_recomendacionVisita",
                table: "DocumentosVisita");

            migrationBuilder.DropColumn(
                name: "Id_finca",
                table: "Caballos");

            migrationBuilder.DropColumn(
                name: "Id_propietario",
                table: "Caballos");

            migrationBuilder.DropColumn(
                name: "Id_veterinarioAsignado",
                table: "Caballos");

            migrationBuilder.AddColumn<int>(
                name: "caballoAsociadoId",
                table: "Historias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "caballoAsociadoId",
                table: "DocumentosVisita",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "recomendacionVisitaId",
                table: "DocumentosVisita",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fincaId",
                table: "Caballos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "propietarioId",
                table: "Caballos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "veterinarioAsignadoId",
                table: "Caballos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Finca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finca", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historias_caballoAsociadoId",
                table: "Historias",
                column: "caballoAsociadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosVisita_caballoAsociadoId",
                table: "DocumentosVisita",
                column: "caballoAsociadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosVisita_recomendacionVisitaId",
                table: "DocumentosVisita",
                column: "recomendacionVisitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Caballos_fincaId",
                table: "Caballos",
                column: "fincaId");

            migrationBuilder.CreateIndex(
                name: "IX_Caballos_propietarioId",
                table: "Caballos",
                column: "propietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Caballos_veterinarioAsignadoId",
                table: "Caballos",
                column: "veterinarioAsignadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caballos_Finca_fincaId",
                table: "Caballos",
                column: "fincaId",
                principalTable: "Finca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Caballos_Personas_propietarioId",
                table: "Caballos",
                column: "propietarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Caballos_Personas_veterinarioAsignadoId",
                table: "Caballos",
                column: "veterinarioAsignadoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosVisita_Caballos_caballoAsociadoId",
                table: "DocumentosVisita",
                column: "caballoAsociadoId",
                principalTable: "Caballos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosVisita_Recomendaciones_recomendacionVisitaId",
                table: "DocumentosVisita",
                column: "recomendacionVisitaId",
                principalTable: "Recomendaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Historias_Caballos_caballoAsociadoId",
                table: "Historias",
                column: "caballoAsociadoId",
                principalTable: "Caballos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
