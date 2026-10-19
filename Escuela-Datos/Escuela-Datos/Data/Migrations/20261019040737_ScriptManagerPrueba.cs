using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escuela_Datos.Data.Migrations
{
    /// <inheritdoc />
    public partial class ScriptManagerPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Escuela",
                columns: table => new
                {
                    IdEscuela = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escuela", x => x.IdEscuela);
                });

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    IdAlumno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEscuela = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.IdAlumno);
                    table.ForeignKey(
                        name: "FK_Alumno_Escuela_IdEscuela",
                        column: x => x.IdEscuela,
                        principalTable: "Escuela",
                        principalColumn: "IdEscuela",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_IdEscuela",
                table: "Alumno",
                column: "IdEscuela");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Escuela");
        }
    }
}
