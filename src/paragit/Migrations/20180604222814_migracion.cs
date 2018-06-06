using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace paragit.Migrations
{
    public partial class migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id_categoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id_categoria);
                });

            migrationBuilder.CreateTable(
                name: "ModoInfo",
                columns: table => new
                {
                    id_modo_info = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    modo_info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModoInfo", x => x.id_modo_info);
                });

            migrationBuilder.CreateTable(
                name: "ModoNoti",
                columns: table => new
                {
                    id_modo_noti = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    modo_noti = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModoNoti", x => x.id_modo_noti);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    id_estado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nom_estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.id_estado);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidad",
                columns: table => new
                {
                    id_nacionalidad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nacionalidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidad", x => x.id_nacionalidad);
                });

            migrationBuilder.CreateTable(
                name: "NivelAcademico",
                columns: table => new
                {
                    id_nivel_academico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nivel_academico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelAcademico", x => x.id_nivel_academico);
                });

            migrationBuilder.CreateTable(
                name: "Ocupacion",
                columns: table => new
                {
                    id_ocupacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ocupacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupacion", x => x.id_ocupacion);
                });

            migrationBuilder.CreateTable(
                name: "TipoArchivo",
                columns: table => new
                {
                    id_tipo_archivo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nom_tipo_archivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArchivo", x => x.id_tipo_archivo);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    id_empleado = table.Column<string>(nullable: false),
                    Categoriaid_categoria = table.Column<int>(nullable: true),
                    ape_empleado = table.Column<string>(nullable: true),
                    estadoid_estado = table.Column<int>(nullable: true),
                    fnac_empleado = table.Column<DateTime>(nullable: false),
                    nacionalidadid_nacionalidad = table.Column<int>(nullable: true),
                    nom_empleado = table.Column<string>(nullable: true),
                    sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.id_empleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Categoria_Categoriaid_categoria",
                        column: x => x.Categoriaid_categoria,
                        principalTable: "Categoria",
                        principalColumn: "id_categoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleado_Estado_estadoid_estado",
                        column: x => x.estadoid_estado,
                        principalTable: "Estado",
                        principalColumn: "id_estado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleado_Nacionalidad_nacionalidadid_nacionalidad",
                        column: x => x.nacionalidadid_nacionalidad,
                        principalTable: "Nacionalidad",
                        principalColumn: "id_nacionalidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id_usuario = table.Column<string>(nullable: false),
                    Nacionalidadid_nacionalidad = table.Column<int>(nullable: true),
                    Nivelacademicoid_nivel_academico = table.Column<int>(nullable: true),
                    Ocupacionid_ocupacion = table.Column<int>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    clave = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    fech_nacimiento = table.Column<DateTime>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    num_DUI = table.Column<int>(nullable: false),
                    sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Nacionalidad_Nacionalidadid_nacionalidad",
                        column: x => x.Nacionalidadid_nacionalidad,
                        principalTable: "Nacionalidad",
                        principalColumn: "id_nacionalidad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_NivelAcademico_Nivelacademicoid_nivel_academico",
                        column: x => x.Nivelacademicoid_nivel_academico,
                        principalTable: "NivelAcademico",
                        principalColumn: "id_nivel_academico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Ocupacion_Ocupacionid_ocupacion",
                        column: x => x.Ocupacionid_ocupacion,
                        principalTable: "Ocupacion",
                        principalColumn: "id_ocupacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Archivo",
                columns: table => new
                {
                    id_archivos = table.Column<string>(nullable: false),
                    Empleadoid_empleado = table.Column<string>(nullable: true),
                    TipoArchivoid_tipo_archivo = table.Column<int>(nullable: true),
                    doc_archivo = table.Column<string>(nullable: true),
                    fecha_archivo = table.Column<DateTime>(nullable: false),
                    n_documento = table.Column<string>(nullable: true),
                    nom_emitio_doc = table.Column<string>(nullable: true),
                    procedencia_doc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archivo", x => x.id_archivos);
                    table.ForeignKey(
                        name: "FK_Archivo_Empleado_Empleadoid_empleado",
                        column: x => x.Empleadoid_empleado,
                        principalTable: "Empleado",
                        principalColumn: "id_empleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Archivo_TipoArchivo_TipoArchivoid_tipo_archivo",
                        column: x => x.TipoArchivoid_tipo_archivo,
                        principalTable: "TipoArchivo",
                        principalColumn: "id_tipo_archivo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    id_solicitud = table.Column<string>(nullable: false),
                    ModoNotiid_modo_noti = table.Column<int>(nullable: true),
                    Modoinfoid_modo_info = table.Column<int>(nullable: true),
                    Usuarioid_usuario = table.Column<string>(nullable: true),
                    fecha_solicitud = table.Column<DateTime>(nullable: false),
                    info_solicitada = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.id_solicitud);
                    table.ForeignKey(
                        name: "FK_Solicitudes_ModoNoti_ModoNotiid_modo_noti",
                        column: x => x.ModoNotiid_modo_noti,
                        principalTable: "ModoNoti",
                        principalColumn: "id_modo_noti",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Solicitudes_ModoInfo_Modoinfoid_modo_info",
                        column: x => x.Modoinfoid_modo_info,
                        principalTable: "ModoInfo",
                        principalColumn: "id_modo_info",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Solicitudes_Usuario_Usuarioid_usuario",
                        column: x => x.Usuarioid_usuario,
                        principalTable: "Usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Despacho",
                columns: table => new
                {
                    id_despacho = table.Column<string>(nullable: false),
                    Modoinfoid_modo_info = table.Column<int>(nullable: true),
                    archivoid_archivos = table.Column<string>(nullable: true),
                    despachosolicitudid_solicitud = table.Column<string>(nullable: true),
                    empleadoid_empleado = table.Column<string>(nullable: true),
                    fecha_despacho = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despacho", x => x.id_despacho);
                    table.ForeignKey(
                        name: "FK_Despacho_ModoInfo_Modoinfoid_modo_info",
                        column: x => x.Modoinfoid_modo_info,
                        principalTable: "ModoInfo",
                        principalColumn: "id_modo_info",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Despacho_Archivo_archivoid_archivos",
                        column: x => x.archivoid_archivos,
                        principalTable: "Archivo",
                        principalColumn: "id_archivos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Despacho_Solicitudes_despachosolicitudid_solicitud",
                        column: x => x.despachosolicitudid_solicitud,
                        principalTable: "Solicitudes",
                        principalColumn: "id_solicitud",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Despacho_Empleado_empleadoid_empleado",
                        column: x => x.empleadoid_empleado,
                        principalTable: "Empleado",
                        principalColumn: "id_empleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Archivo_Empleadoid_empleado",
                table: "Archivo",
                column: "Empleadoid_empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Archivo_TipoArchivoid_tipo_archivo",
                table: "Archivo",
                column: "TipoArchivoid_tipo_archivo");

            migrationBuilder.CreateIndex(
                name: "IX_Despacho_Modoinfoid_modo_info",
                table: "Despacho",
                column: "Modoinfoid_modo_info");

            migrationBuilder.CreateIndex(
                name: "IX_Despacho_archivoid_archivos",
                table: "Despacho",
                column: "archivoid_archivos");

            migrationBuilder.CreateIndex(
                name: "IX_Despacho_despachosolicitudid_solicitud",
                table: "Despacho",
                column: "despachosolicitudid_solicitud");

            migrationBuilder.CreateIndex(
                name: "IX_Despacho_empleadoid_empleado",
                table: "Despacho",
                column: "empleadoid_empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_Categoriaid_categoria",
                table: "Empleado",
                column: "Categoriaid_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_estadoid_estado",
                table: "Empleado",
                column: "estadoid_estado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_nacionalidadid_nacionalidad",
                table: "Empleado",
                column: "nacionalidadid_nacionalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_ModoNotiid_modo_noti",
                table: "Solicitudes",
                column: "ModoNotiid_modo_noti");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_Modoinfoid_modo_info",
                table: "Solicitudes",
                column: "Modoinfoid_modo_info");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_Usuarioid_usuario",
                table: "Solicitudes",
                column: "Usuarioid_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Nacionalidadid_nacionalidad",
                table: "Usuario",
                column: "Nacionalidadid_nacionalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Nivelacademicoid_nivel_academico",
                table: "Usuario",
                column: "Nivelacademicoid_nivel_academico");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Ocupacionid_ocupacion",
                table: "Usuario",
                column: "Ocupacionid_ocupacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despacho");

            migrationBuilder.DropTable(
                name: "Archivo");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "TipoArchivo");

            migrationBuilder.DropTable(
                name: "ModoNoti");

            migrationBuilder.DropTable(
                name: "ModoInfo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Nacionalidad");

            migrationBuilder.DropTable(
                name: "NivelAcademico");

            migrationBuilder.DropTable(
                name: "Ocupacion");
        }
    }
}
