using Microsoft.EntityFrameworkCore.Migrations;

namespace EstanciaCaballos.App.Persistencia.Migrations
{
    public partial class carga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Finca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    licencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estaDisponible = table.Column<bool>(type: "bit", nullable: true),
                    horarioAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recomendaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dosisMedicamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frecuenciaMedicamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cuidados = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caballos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    veterinarioAsignadoId = table.Column<int>(type: "int", nullable: true),
                    propietarioId = table.Column<int>(type: "int", nullable: true),
                    fincaId = table.Column<int>(type: "int", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caballos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caballos_Finca_fincaId",
                        column: x => x.fincaId,
                        principalTable: "Finca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Caballos_Personas_propietarioId",
                        column: x => x.propietarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Caballos_Personas_veterinarioAsignadoId",
                        column: x => x.veterinarioAsignadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosVisita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    caballoAsociadoId = table.Column<int>(type: "int", nullable: true),
                    recomendacionVisitaId = table.Column<int>(type: "int", nullable: true),
                    fechaVisita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperatura = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<int>(type: "int", nullable: false),
                    frecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    frecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    estadoDeAnimo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosVisita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentosVisita_Caballos_caballoAsociadoId",
                        column: x => x.caballoAsociadoId,
                        principalTable: "Caballos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentosVisita_Recomendaciones_recomendacionVisitaId",
                        column: x => x.recomendacionVisitaId,
                        principalTable: "Recomendaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitasRealizadas = table.Column<int>(type: "int", nullable: false),
                    caballoAsociadoId = table.Column<int>(type: "int", nullable: true),
                    fechaInicioHistoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historias_Caballos_caballoAsociadoId",
                        column: x => x.caballoAsociadoId,
                        principalTable: "Caballos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosVisita_caballoAsociadoId",
                table: "DocumentosVisita",
                column: "caballoAsociadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosVisita_recomendacionVisitaId",
                table: "DocumentosVisita",
                column: "recomendacionVisitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historias_caballoAsociadoId",
                table: "Historias",
                column: "caballoAsociadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentosVisita");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Recomendaciones");

            migrationBuilder.DropTable(
                name: "Caballos");

            migrationBuilder.DropTable(
                name: "Finca");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
