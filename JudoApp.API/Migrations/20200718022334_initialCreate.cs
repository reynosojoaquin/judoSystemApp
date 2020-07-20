using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace JudoApp.API.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atletas",
                columns: table => new
                {
                    atletaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    personaID = table.Column<int>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    indiceDeportivo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atletas", x => x.atletaID);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    cargoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.cargoID);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    ciudadID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    provinciaID = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.ciudadID);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    contactoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    personaID = table.Column<int>(nullable: false),
                    parentescoID = table.Column<int>(nullable: false),
                    principal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.contactoID);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    direccionID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    referencia = table.Column<int>(nullable: false),
                    calle = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    apartamento = table.Column<string>(nullable: true),
                    sectorID = table.Column<int>(nullable: false),
                    Coordenadas = table.Column<string>(nullable: true),
                    Disponible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.direccionID);
                });

            migrationBuilder.CreateTable(
                name: "eventos",
                columns: table => new
                {
                    eventoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventos", x => x.eventoID);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinicaTipos",
                columns: table => new
                {
                    historiaClinicaTipoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinicaTipos", x => x.historiaClinicaTipoID);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinica",
                columns: table => new
                {
                    historiaclinicaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    personaID = table.Column<int>(nullable: false),
                    historialTipoID = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    relevancia = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinica", x => x.historiaclinicaID);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    paisID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.paisID);
                });

            migrationBuilder.CreateTable(
                name: "Parentescos",
                columns: table => new
                {
                    parentescoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentescos", x => x.parentescoID);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    telefonoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    referencia = table.Column<int>(nullable: false),
                    tipoID = table.Column<int>(nullable: false),
                    numeroTelefonico = table.Column<string>(nullable: true),
                    principal = table.Column<bool>(nullable: false),
                    disponible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.telefonoID);
                });

            migrationBuilder.CreateTable(
                name: "TiposEvento",
                columns: table => new
                {
                    tipoeventoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEvento", x => x.tipoeventoID);
                });

            migrationBuilder.CreateTable(
                name: "tiposTelefono",
                columns: table => new
                {
                    tipoTelefonoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposTelefono", x => x.tipoTelefonoID);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    sectorID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ciudadID = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.sectorID);
                    table.ForeignKey(
                        name: "FK_Sectores_Ciudades_ciudadID",
                        column: x => x.ciudadID,
                        principalTable: "Ciudades",
                        principalColumn: "ciudadID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historialesDeportivo",
                columns: table => new
                {
                    historialDeportivoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    atletaID = table.Column<int>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    direccionID = table.Column<int>(nullable: true),
                    lugarObtenido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historialesDeportivo", x => x.historialDeportivoID);
                    table.ForeignKey(
                        name: "FK_historialesDeportivo_Atletas_atletaID",
                        column: x => x.atletaID,
                        principalTable: "Atletas",
                        principalColumn: "atletaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historialesDeportivo_Direcciones_direccionID",
                        column: x => x.direccionID,
                        principalTable: "Direcciones",
                        principalColumn: "direccionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    provinciaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    paisID = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.provinciaID);
                    table.ForeignKey(
                        name: "FK_Provincias_Paises_paisID",
                        column: x => x.paisID,
                        principalTable: "Paises",
                        principalColumn: "paisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clubes",
                columns: table => new
                {
                    ClubID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fechaCreacion = table.Column<DateTime>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    activo = table.Column<bool>(nullable: false),
                    telefonoID = table.Column<int>(nullable: true),
                    direccionID = table.Column<int>(nullable: true),
                    contactoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubes", x => x.ClubID);
                    table.ForeignKey(
                        name: "FK_Clubes_Contactos_contactoID",
                        column: x => x.contactoID,
                        principalTable: "Contactos",
                        principalColumn: "contactoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clubes_Direcciones_direccionID",
                        column: x => x.direccionID,
                        principalTable: "Direcciones",
                        principalColumn: "direccionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clubes_Telefonos_telefonoID",
                        column: x => x.telefonoID,
                        principalTable: "Telefonos",
                        principalColumn: "telefonoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Miembros",
                columns: table => new
                {
                    miembroID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    personaID = table.Column<int>(nullable: false),
                    clubID = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    fechaIngredo = table.Column<DateTime>(nullable: false),
                    sexo = table.Column<int>(nullable: true),
                    telefonoID = table.Column<int>(nullable: true),
                    correoElectronico = table.Column<string>(nullable: true),
                    direccionID = table.Column<int>(nullable: true),
                    activo = table.Column<bool>(nullable: false),
                    contactoID = table.Column<int>(nullable: true),
                    historiaclinicaID = table.Column<int>(nullable: true),
                    cedula = table.Column<string>(nullable: true),
                    folio = table.Column<string>(nullable: true),
                    circunscripcion = table.Column<int>(nullable: true),
                    nivelEducativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miembros", x => x.miembroID);
                    table.ForeignKey(
                        name: "FK_Miembros_Contactos_contactoID",
                        column: x => x.contactoID,
                        principalTable: "Contactos",
                        principalColumn: "contactoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Miembros_Direcciones_direccionID",
                        column: x => x.direccionID,
                        principalTable: "Direcciones",
                        principalColumn: "direccionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Miembros_HistoriasClinica_historiaclinicaID",
                        column: x => x.historiaclinicaID,
                        principalTable: "HistoriasClinica",
                        principalColumn: "historiaclinicaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Miembros_Telefonos_telefonoID",
                        column: x => x.telefonoID,
                        principalTable: "Telefonos",
                        principalColumn: "telefonoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadisticas",
                columns: table => new
                {
                    estadisticaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    historialDeportivoID = table.Column<int>(nullable: false),
                    combateID = table.Column<int>(nullable: false),
                    evantoID = table.Column<int>(nullable: false),
                    tiempo = table.Column<DateTime>(nullable: false),
                    puntuacion = table.Column<int>(nullable: false),
                    evantoTipoID = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas", x => x.estadisticaID);
                    table.ForeignKey(
                        name: "FK_Estadisticas_historialesDeportivo_historialDeportivoID",
                        column: x => x.historialDeportivoID,
                        principalTable: "historialesDeportivo",
                        principalColumn: "historialDeportivoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComiteteEjecutivo",
                columns: table => new
                {
                    comiteEjecutivoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    personaID = table.Column<int>(nullable: false),
                    clubID = table.Column<int>(nullable: false),
                    CargoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComiteteEjecutivo", x => x.comiteEjecutivoID);
                    table.ForeignKey(
                        name: "FK_ComiteteEjecutivo_Clubes_clubID",
                        column: x => x.clubID,
                        principalTable: "Clubes",
                        principalColumn: "ClubID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubes_contactoID",
                table: "Clubes",
                column: "contactoID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubes_direccionID",
                table: "Clubes",
                column: "direccionID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubes_telefonoID",
                table: "Clubes",
                column: "telefonoID");

            migrationBuilder.CreateIndex(
                name: "IX_ComiteteEjecutivo_clubID",
                table: "ComiteteEjecutivo",
                column: "clubID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estadisticas_historialDeportivoID",
                table: "Estadisticas",
                column: "historialDeportivoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_historialesDeportivo_atletaID",
                table: "historialesDeportivo",
                column: "atletaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_historialesDeportivo_direccionID",
                table: "historialesDeportivo",
                column: "direccionID");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_contactoID",
                table: "Miembros",
                column: "contactoID");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_direccionID",
                table: "Miembros",
                column: "direccionID");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_historiaclinicaID",
                table: "Miembros",
                column: "historiaclinicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_telefonoID",
                table: "Miembros",
                column: "telefonoID");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_paisID",
                table: "Provincias",
                column: "paisID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sectores_ciudadID",
                table: "Sectores",
                column: "ciudadID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "ComiteteEjecutivo");

            migrationBuilder.DropTable(
                name: "Estadisticas");

            migrationBuilder.DropTable(
                name: "eventos");

            migrationBuilder.DropTable(
                name: "HistoriaClinicaTipos");

            migrationBuilder.DropTable(
                name: "Miembros");

            migrationBuilder.DropTable(
                name: "Parentescos");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "TiposEvento");

            migrationBuilder.DropTable(
                name: "tiposTelefono");

            migrationBuilder.DropTable(
                name: "Clubes");

            migrationBuilder.DropTable(
                name: "historialesDeportivo");

            migrationBuilder.DropTable(
                name: "HistoriasClinica");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "Atletas");

            migrationBuilder.DropTable(
                name: "Direcciones");
        }
    }
}
