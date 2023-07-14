﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(miEpsContext))]
    [Migration("20230713175824_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Acudiente", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Code");

                    b.ToTable("Acudiente");
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.Property<int>("Cit_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Cit_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Cit_Doctor")
                        .HasColumnType("int");

                    b.Property<int>("Cit_State")
                        .HasColumnType("int");

                    b.Property<int>("Cit_UserData")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoCitasEstcit_Id")
                        .HasColumnType("int");

                    b.Property<string>("FullNameMedico")
                        .HasColumnType("longtext");

                    b.Property<string>("IdEstadoCita")
                        .HasColumnType("longtext");

                    b.Property<int?>("MedicosMed_PersonalRegistrationNumber")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumberUser")
                        .HasColumnType("longtext");

                    b.Property<int?>("UsuariosUsu_Id")
                        .HasColumnType("int");

                    b.HasKey("Cit_Code");

                    b.HasIndex("EstadoCitasEstcit_Id");

                    b.HasIndex("MedicosMed_PersonalRegistrationNumber");

                    b.HasIndex("UsuariosUsu_Id");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("Core.Entities.Consultorio", b =>
                {
                    b.Property<int>("Cons_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cons_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Cons_Code");

                    b.ToTable("Consultorio");
                });

            modelBuilder.Entity("Core.Entities.Especialidad", b =>
                {
                    b.Property<int>("Esp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Esp_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Esp_Id");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("Core.Entities.EstadoCita", b =>
                {
                    b.Property<int>("Estcit_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estcit_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Estcit_Id");

                    b.ToTable("EstadoCita");
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Property<int>("Gen_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Gen_Abbreviation")
                        .HasColumnType("longtext");

                    b.Property<string>("Gen_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Gen_Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.Property<int>("Med_PersonalRegistrationNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ConsultoriosCons_Code")
                        .HasColumnType("int");

                    b.Property<int?>("EspecialidadesEsp_Id")
                        .HasColumnType("int");

                    b.Property<string>("IdConsultorio")
                        .HasColumnType("longtext");

                    b.Property<string>("IdEspecialidad")
                        .HasColumnType("longtext");

                    b.Property<string>("Med_FullName")
                        .HasColumnType("longtext");

                    b.Property<int>("Med_Office")
                        .HasColumnType("int");

                    b.Property<int>("Med_Specialty")
                        .HasColumnType("int");

                    b.HasKey("Med_PersonalRegistrationNumber");

                    b.HasIndex("ConsultoriosCons_Code");

                    b.HasIndex("EspecialidadesEsp_Id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Tipdoc_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tipdoc_Abbreviation")
                        .HasColumnType("longtext");

                    b.Property<string>("Tipdoc_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Tipdoc_Id");

                    b.ToTable("TipoDocumento");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Property<int>("Usu_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AcudientesCode")
                        .HasColumnType("int");

                    b.Property<string>("FullNameAcudiente")
                        .HasColumnType("longtext");

                    b.Property<int?>("GenerosGen_Id")
                        .HasColumnType("int");

                    b.Property<string>("NameGenero")
                        .HasColumnType("longtext");

                    b.Property<string>("NameTipoDocumento")
                        .HasColumnType("longtext");

                    b.Property<int?>("TipoDocumentosTipdoc_Id")
                        .HasColumnType("int");

                    b.Property<string>("Usu_Address")
                        .HasColumnType("longtext");

                    b.Property<int>("Usu_Attendant")
                        .HasColumnType("int");

                    b.Property<string>("Usu_Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Usu_FirstName")
                        .HasColumnType("longtext");

                    b.Property<int>("Usu_Gender")
                        .HasColumnType("int");

                    b.Property<string>("Usu_Lastname")
                        .HasColumnType("longtext");

                    b.Property<string>("Usu_PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Usu_SecondLastname")
                        .HasColumnType("longtext");

                    b.Property<string>("Usu_SecondName")
                        .HasColumnType("longtext");

                    b.Property<int>("Usu_Tipodoc")
                        .HasColumnType("int");

                    b.HasKey("Usu_Id");

                    b.HasIndex("AcudientesCode");

                    b.HasIndex("GenerosGen_Id");

                    b.HasIndex("TipoDocumentosTipdoc_Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.HasOne("Core.Entities.EstadoCita", "EstadoCitas")
                        .WithMany("Citas")
                        .HasForeignKey("EstadoCitasEstcit_Id");

                    b.HasOne("Core.Entities.Medico", "Medicos")
                        .WithMany("Citas")
                        .HasForeignKey("MedicosMed_PersonalRegistrationNumber");

                    b.HasOne("Core.Entities.Usuario", "Usuarios")
                        .WithMany("Citas")
                        .HasForeignKey("UsuariosUsu_Id");

                    b.Navigation("EstadoCitas");

                    b.Navigation("Medicos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.HasOne("Core.Entities.Consultorio", "Consultorios")
                        .WithMany("Medicos")
                        .HasForeignKey("ConsultoriosCons_Code");

                    b.HasOne("Core.Entities.Especialidad", "Especialidades")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadesEsp_Id");

                    b.Navigation("Consultorios");

                    b.Navigation("Especialidades");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.HasOne("Core.Entities.Acudiente", "Acudientes")
                        .WithMany("Usuarios")
                        .HasForeignKey("AcudientesCode");

                    b.HasOne("Core.Entities.Genero", "Generos")
                        .WithMany("Usuarios")
                        .HasForeignKey("GenerosGen_Id");

                    b.HasOne("Core.Entities.TipoDocumento", "TipoDocumentos")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoDocumentosTipdoc_Id");

                    b.Navigation("Acudientes");

                    b.Navigation("Generos");

                    b.Navigation("TipoDocumentos");
                });

            modelBuilder.Entity("Core.Entities.Acudiente", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Consultorio", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entities.Especialidad", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entities.EstadoCita", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
