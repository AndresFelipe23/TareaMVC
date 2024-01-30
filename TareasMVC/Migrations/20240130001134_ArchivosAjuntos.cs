using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class ArchivosAjuntos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArchivoAdjunto_Tareas_TareaId",
                table: "ArchivoAdjunto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArchivoAdjunto",
                table: "ArchivoAdjunto");

            migrationBuilder.RenameTable(
                name: "ArchivoAdjunto",
                newName: "ArchivosAdjuntos");

            migrationBuilder.RenameIndex(
                name: "IX_ArchivoAdjunto_TareaId",
                table: "ArchivosAdjuntos",
                newName: "IX_ArchivosAdjuntos_TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArchivosAdjuntos",
                table: "ArchivosAdjuntos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArchivosAdjuntos_Tareas_TareaId",
                table: "ArchivosAdjuntos",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArchivosAdjuntos_Tareas_TareaId",
                table: "ArchivosAdjuntos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArchivosAdjuntos",
                table: "ArchivosAdjuntos");

            migrationBuilder.RenameTable(
                name: "ArchivosAdjuntos",
                newName: "ArchivoAdjunto");

            migrationBuilder.RenameIndex(
                name: "IX_ArchivosAdjuntos_TareaId",
                table: "ArchivoAdjunto",
                newName: "IX_ArchivoAdjunto_TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArchivoAdjunto",
                table: "ArchivoAdjunto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArchivoAdjunto_Tareas_TareaId",
                table: "ArchivoAdjunto",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
