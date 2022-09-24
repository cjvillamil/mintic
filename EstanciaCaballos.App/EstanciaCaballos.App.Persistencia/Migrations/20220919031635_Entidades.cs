using Microsoft.EntityFrameworkCore.Migrations;

namespace EstanciaCaballos.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fincaId",
                table: "Caballos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Caballos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "persona2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona2", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caballos_fincaId",
                table: "Caballos",
                column: "fincaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caballos_Finca_fincaId",
                table: "Caballos",
                column: "fincaId",
                principalTable: "Finca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caballos_Finca_fincaId",
                table: "Caballos");

            migrationBuilder.DropTable(
                name: "Finca");

            migrationBuilder.DropTable(
                name: "persona2");

            migrationBuilder.DropIndex(
                name: "IX_Caballos_fincaId",
                table: "Caballos");

            migrationBuilder.DropColumn(
                name: "fincaId",
                table: "Caballos");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Caballos");
        }
    }
}
