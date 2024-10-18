using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea5.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plataformas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Activa = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videojuegos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Desarrollador = table.Column<string>(type: "TEXT", nullable: true),
                    PlatformId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlataformaId = table.Column<int>(type: "INTEGER", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CoverImage = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videojuegos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Videojuegos_Plataformas_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataformas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    HabilidadEspecial = table.Column<string>(type: "TEXT", nullable: true),
                    ArmaFavorita = table.Column<string>(type: "TEXT", nullable: true),
                    PowerLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonajeImg = table.Column<string>(type: "TEXT", nullable: true),
                    VideojuegoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personajes_Videojuegos_VideojuegoId",
                        column: x => x.VideojuegoId,
                        principalTable: "Videojuegos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_VideojuegoId",
                table: "Personajes",
                column: "VideojuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videojuegos_PlataformaId",
                table: "Videojuegos",
                column: "PlataformaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Videojuegos");

            migrationBuilder.DropTable(
                name: "Plataformas");
        }
    }
}
