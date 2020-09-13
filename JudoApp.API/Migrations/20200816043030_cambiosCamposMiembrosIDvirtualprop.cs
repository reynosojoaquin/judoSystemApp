using Microsoft.EntityFrameworkCore.Migrations;

namespace JudoApp.API.Migrations
{
    public partial class cambiosCamposMiembrosIDvirtualprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sexoDescripcion",
                table: "Miembros",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_clubID",
                table: "Miembros",
                column: "clubID");

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Clubes_clubID",
                table: "Miembros",
                column: "clubID",
                principalTable: "Clubes",
                principalColumn: "ClubID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Clubes_clubID",
                table: "Miembros");

            migrationBuilder.DropIndex(
                name: "IX_Miembros_clubID",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "sexoDescripcion",
                table: "Miembros");
        }
    }
}
