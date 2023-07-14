using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Acudiente",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudiente", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Consultorio",
                columns: table => new
                {
                    Cons_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cons_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorio", x => x.Cons_Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    Esp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Esp_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.Esp_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoCita",
                columns: table => new
                {
                    Estcit_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estcit_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCita", x => x.Estcit_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Gen_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Gen_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gen_Abbreviation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Gen_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    Tipdoc_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipdoc_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipdoc_Abbreviation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.Tipdoc_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Med_PersonalRegistrationNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Med_FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Med_Office = table.Column<int>(type: "int", nullable: false),
                    Med_Specialty = table.Column<int>(type: "int", nullable: false),
                    IdEspecialidad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EspecialidadesEsp_Id = table.Column<int>(type: "int", nullable: true),
                    IdConsultorio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConsultoriosCons_Code = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Med_PersonalRegistrationNumber);
                    table.ForeignKey(
                        name: "FK_Medico_Consultorio_ConsultoriosCons_Code",
                        column: x => x.ConsultoriosCons_Code,
                        principalTable: "Consultorio",
                        principalColumn: "Cons_Code");
                    table.ForeignKey(
                        name: "FK_Medico_Especialidad_EspecialidadesEsp_Id",
                        column: x => x.EspecialidadesEsp_Id,
                        principalTable: "Especialidad",
                        principalColumn: "Esp_Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Usu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Usu_FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_SecondName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_Lastname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_SecondLastname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_Tipodoc = table.Column<int>(type: "int", nullable: false),
                    Usu_Gender = table.Column<int>(type: "int", nullable: false),
                    Usu_Attendant = table.Column<int>(type: "int", nullable: false),
                    NameTipoDocumento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoDocumentosTipdoc_Id = table.Column<int>(type: "int", nullable: true),
                    NameGenero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GenerosGen_Id = table.Column<int>(type: "int", nullable: true),
                    FullNameAcudiente = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcudientesCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Usu_Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Acudiente_AcudientesCode",
                        column: x => x.AcudientesCode,
                        principalTable: "Acudiente",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Usuario_Genero_GenerosGen_Id",
                        column: x => x.GenerosGen_Id,
                        principalTable: "Genero",
                        principalColumn: "Gen_Id");
                    table.ForeignKey(
                        name: "FK_Usuario_TipoDocumento_TipoDocumentosTipdoc_Id",
                        column: x => x.TipoDocumentosTipdoc_Id,
                        principalTable: "TipoDocumento",
                        principalColumn: "Tipdoc_Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    Cit_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cit_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Cit_State = table.Column<int>(type: "int", nullable: false),
                    Cit_Doctor = table.Column<int>(type: "int", nullable: false),
                    Cit_UserData = table.Column<int>(type: "int", nullable: false),
                    PhoneNumberUser = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuariosUsu_Id = table.Column<int>(type: "int", nullable: true),
                    IdEstadoCita = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoCitasEstcit_Id = table.Column<int>(type: "int", nullable: true),
                    FullNameMedico = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MedicosMed_PersonalRegistrationNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.Cit_Code);
                    table.ForeignKey(
                        name: "FK_Cita_EstadoCita_EstadoCitasEstcit_Id",
                        column: x => x.EstadoCitasEstcit_Id,
                        principalTable: "EstadoCita",
                        principalColumn: "Estcit_Id");
                    table.ForeignKey(
                        name: "FK_Cita_Medico_MedicosMed_PersonalRegistrationNumber",
                        column: x => x.MedicosMed_PersonalRegistrationNumber,
                        principalTable: "Medico",
                        principalColumn: "Med_PersonalRegistrationNumber");
                    table.ForeignKey(
                        name: "FK_Cita_Usuario_UsuariosUsu_Id",
                        column: x => x.UsuariosUsu_Id,
                        principalTable: "Usuario",
                        principalColumn: "Usu_Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_EstadoCitasEstcit_Id",
                table: "Cita",
                column: "EstadoCitasEstcit_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_MedicosMed_PersonalRegistrationNumber",
                table: "Cita",
                column: "MedicosMed_PersonalRegistrationNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_UsuariosUsu_Id",
                table: "Cita",
                column: "UsuariosUsu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_ConsultoriosCons_Code",
                table: "Medico",
                column: "ConsultoriosCons_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_EspecialidadesEsp_Id",
                table: "Medico",
                column: "EspecialidadesEsp_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcudientesCode",
                table: "Usuario",
                column: "AcudientesCode");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_GenerosGen_Id",
                table: "Usuario",
                column: "GenerosGen_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipoDocumentosTipdoc_Id",
                table: "Usuario",
                column: "TipoDocumentosTipdoc_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "EstadoCita");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Consultorio");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoDocumento");
        }
    }
}
