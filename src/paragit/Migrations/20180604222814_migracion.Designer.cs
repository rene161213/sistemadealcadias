using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using paragit.Models;

namespace paragit.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180604222814_migracion")]
    partial class migracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("paragit.Models.Archivo", b =>
                {
                    b.Property<string>("id_archivos");

                    b.Property<string>("Empleadoid_empleado");

                    b.Property<int?>("TipoArchivoid_tipo_archivo");

                    b.Property<string>("doc_archivo");

                    b.Property<DateTime>("fecha_archivo");

                    b.Property<string>("n_documento");

                    b.Property<string>("nom_emitio_doc");

                    b.Property<string>("procedencia_doc");

                    b.HasKey("id_archivos");

                    b.HasIndex("Empleadoid_empleado");

                    b.HasIndex("TipoArchivoid_tipo_archivo");

                    b.ToTable("Archivo");
                });

            modelBuilder.Entity("paragit.Models.Categoria", b =>
                {
                    b.Property<int>("id_categoria")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("categoria");

                    b.HasKey("id_categoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("paragit.Models.CatModoInformacion", b =>
                {
                    b.Property<int>("id_modo_info")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("modo_info");

                    b.HasKey("id_modo_info");

                    b.ToTable("ModoInfo");
                });

            modelBuilder.Entity("paragit.Models.CatModoNotificacion", b =>
                {
                    b.Property<int>("id_modo_noti")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("modo_noti");

                    b.HasKey("id_modo_noti");

                    b.ToTable("ModoNoti");
                });

            modelBuilder.Entity("paragit.Models.DespachoSolicitud", b =>
                {
                    b.Property<string>("id_despacho");

                    b.Property<int?>("Modoinfoid_modo_info");

                    b.Property<string>("archivoid_archivos");

                    b.Property<string>("despachosolicitudid_solicitud");

                    b.Property<string>("empleadoid_empleado");

                    b.Property<DateTime>("fecha_despacho");

                    b.HasKey("id_despacho");

                    b.HasIndex("Modoinfoid_modo_info");

                    b.HasIndex("archivoid_archivos");

                    b.HasIndex("despachosolicitudid_solicitud");

                    b.HasIndex("empleadoid_empleado");

                    b.ToTable("Despacho");
                });

            modelBuilder.Entity("paragit.Models.Empleado", b =>
                {
                    b.Property<string>("id_empleado");

                    b.Property<int?>("Categoriaid_categoria");

                    b.Property<string>("ape_empleado");

                    b.Property<int?>("estadoid_estado");

                    b.Property<DateTime>("fnac_empleado");

                    b.Property<int?>("nacionalidadid_nacionalidad");

                    b.Property<string>("nom_empleado");

                    b.Property<string>("sexo");

                    b.HasKey("id_empleado");

                    b.HasIndex("Categoriaid_categoria");

                    b.HasIndex("estadoid_estado");

                    b.HasIndex("nacionalidadid_nacionalidad");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("paragit.Models.Estado", b =>
                {
                    b.Property<int>("id_estado")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nom_estado");

                    b.HasKey("id_estado");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("paragit.Models.Nacionalidad", b =>
                {
                    b.Property<int>("id_nacionalidad")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nacionalidad");

                    b.HasKey("id_nacionalidad");

                    b.ToTable("Nacionalidad");
                });

            modelBuilder.Entity("paragit.Models.NivelAcademico", b =>
                {
                    b.Property<int>("id_nivel_academico")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nivel_academico");

                    b.HasKey("id_nivel_academico");

                    b.ToTable("NivelAcademico");
                });

            modelBuilder.Entity("paragit.Models.Ocupacion", b =>
                {
                    b.Property<int>("id_ocupacion")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ocupacion");

                    b.HasKey("id_ocupacion");

                    b.ToTable("Ocupacion");
                });

            modelBuilder.Entity("paragit.Models.Solicitudes", b =>
                {
                    b.Property<string>("id_solicitud");

                    b.Property<int?>("ModoNotiid_modo_noti");

                    b.Property<int?>("Modoinfoid_modo_info");

                    b.Property<string>("Usuarioid_usuario");

                    b.Property<DateTime>("fecha_solicitud");

                    b.Property<string>("info_solicitada");

                    b.HasKey("id_solicitud");

                    b.HasIndex("ModoNotiid_modo_noti");

                    b.HasIndex("Modoinfoid_modo_info");

                    b.HasIndex("Usuarioid_usuario");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("paragit.Models.TipoArchivo", b =>
                {
                    b.Property<int>("id_tipo_archivo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nom_tipo_archivo");

                    b.HasKey("id_tipo_archivo");

                    b.ToTable("TipoArchivo");
                });

            modelBuilder.Entity("paragit.Models.Usuario", b =>
                {
                    b.Property<string>("id_usuario");

                    b.Property<int?>("Nacionalidadid_nacionalidad");

                    b.Property<int?>("Nivelacademicoid_nivel_academico");

                    b.Property<int?>("Ocupacionid_ocupacion");

                    b.Property<string>("apellido");

                    b.Property<string>("clave");

                    b.Property<string>("email");

                    b.Property<DateTime>("fech_nacimiento");

                    b.Property<string>("nombre");

                    b.Property<int>("num_DUI");

                    b.Property<string>("sexo");

                    b.HasKey("id_usuario");

                    b.HasIndex("Nacionalidadid_nacionalidad");

                    b.HasIndex("Nivelacademicoid_nivel_academico");

                    b.HasIndex("Ocupacionid_ocupacion");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("paragit.Models.Archivo", b =>
                {
                    b.HasOne("paragit.Models.Empleado", "Empleado")
                        .WithMany("CodEmpleado")
                        .HasForeignKey("Empleadoid_empleado");

                    b.HasOne("paragit.Models.TipoArchivo", "TipoArchivo")
                        .WithMany("archivos")
                        .HasForeignKey("TipoArchivoid_tipo_archivo");
                });

            modelBuilder.Entity("paragit.Models.DespachoSolicitud", b =>
                {
                    b.HasOne("paragit.Models.CatModoInformacion", "Modoinfo")
                        .WithMany("Despacho")
                        .HasForeignKey("Modoinfoid_modo_info");

                    b.HasOne("paragit.Models.Archivo", "archivo")
                        .WithMany("archivo")
                        .HasForeignKey("archivoid_archivos");

                    b.HasOne("paragit.Models.Solicitudes", "despachosolicitud")
                        .WithMany("despachosolicitud")
                        .HasForeignKey("despachosolicitudid_solicitud");

                    b.HasOne("paragit.Models.Empleado", "empleado")
                        .WithMany("DespachoSolicitud")
                        .HasForeignKey("empleadoid_empleado");
                });

            modelBuilder.Entity("paragit.Models.Empleado", b =>
                {
                    b.HasOne("paragit.Models.Categoria", "Categoria")
                        .WithMany("Empleado")
                        .HasForeignKey("Categoriaid_categoria");

                    b.HasOne("paragit.Models.Estado", "estado")
                        .WithMany("empleado")
                        .HasForeignKey("estadoid_estado");

                    b.HasOne("paragit.Models.Nacionalidad", "nacionalidad")
                        .WithMany("nacion")
                        .HasForeignKey("nacionalidadid_nacionalidad");
                });

            modelBuilder.Entity("paragit.Models.Solicitudes", b =>
                {
                    b.HasOne("paragit.Models.CatModoNotificacion", "ModoNoti")
                        .WithMany("Solicitud")
                        .HasForeignKey("ModoNotiid_modo_noti");

                    b.HasOne("paragit.Models.CatModoInformacion", "Modoinfo")
                        .WithMany("Solicitud")
                        .HasForeignKey("Modoinfoid_modo_info");

                    b.HasOne("paragit.Models.Usuario", "Usuario")
                        .WithMany("solicitudes")
                        .HasForeignKey("Usuarioid_usuario");
                });

            modelBuilder.Entity("paragit.Models.Usuario", b =>
                {
                    b.HasOne("paragit.Models.Nacionalidad", "Nacionalidad")
                        .WithMany("Usuario")
                        .HasForeignKey("Nacionalidadid_nacionalidad");

                    b.HasOne("paragit.Models.NivelAcademico", "Nivelacademico")
                        .WithMany("Usuario")
                        .HasForeignKey("Nivelacademicoid_nivel_academico");

                    b.HasOne("paragit.Models.Ocupacion", "Ocupacion")
                        .WithMany("Usuario")
                        .HasForeignKey("Ocupacionid_ocupacion");
                });
        }
    }
}
