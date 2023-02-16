using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class initMySql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Matricula = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Registro = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunoCurso",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoCurso", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CargaHoraria = table.Column<int>(nullable: false),
                    ProfessorId = table.Column<int>(nullable: false),
                    PrerequisitoId = table.Column<int>(nullable: true),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Disciplinas_PrerequisitoId",
                        column: x => x.PrerequisitoId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Nota = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataIni", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 194, DateTimeKind.Local).AddTicks(8752), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Marta", "Kent", "33225555" },
                    { 2, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(6822), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Paula", "Isabela", "3354288" },
                    { 3, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7066), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Laura", "Antonia", "55668899" },
                    { 4, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7100), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Luiza", "Maria", "6565659" },
                    { 5, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7124), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Lucas", "Machado", "565685415" },
                    { 6, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7172), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Pedro", "Alvares", "456454545" },
                    { 7, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7198), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Paulo", "José", "9874512" }
                });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Tecnologia da Informação" },
                    { 2, "Sistemas de Informação" },
                    { 3, "Ciência da Computação" }
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "Nome", "Registro", "Sobrenome" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 185, DateTimeKind.Local).AddTicks(2913), "Lauro", 1, "Oliveira" },
                    { 2, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8208), "Roberto", 2, "Soares" },
                    { 3, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8312), "Ronaldo", 3, "Marconi" },
                    { 4, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8318), "Rodrigo", 4, "Carvalho" },
                    { 5, true, null, new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8321), "Alexandre", 5, "Montanha" }
                });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[,]
                {
                    { 1, 0, 1, "Matemática", null, 1 },
                    { 2, 0, 3, "Matemática", null, 1 },
                    { 3, 0, 3, "Física", null, 2 },
                    { 4, 0, 1, "Português", null, 3 },
                    { 5, 0, 1, "Inglês", null, 4 },
                    { 6, 0, 2, "Inglês", null, 4 },
                    { 7, 0, 3, "Inglês", null, 4 },
                    { 8, 0, 1, "Programação", null, 5 },
                    { 9, 0, 2, "Programação", null, 5 },
                    { 10, 0, 3, "Programação", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[,]
                {
                    { 2, 1, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5109), null },
                    { 4, 5, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5139), null },
                    { 2, 5, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5121), null },
                    { 1, 5, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5105), null },
                    { 7, 4, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5539), null },
                    { 6, 4, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5517), null },
                    { 5, 4, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5142), null },
                    { 4, 4, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5137), null },
                    { 1, 4, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5045), null },
                    { 7, 3, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5536), null },
                    { 5, 5, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5144), null },
                    { 6, 3, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5151), null },
                    { 7, 2, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5532), null },
                    { 6, 2, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5149), null },
                    { 3, 2, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5127), null },
                    { 2, 2, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5111), null },
                    { 1, 2, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(2935), null },
                    { 7, 1, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5528), null },
                    { 6, 1, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5146), null },
                    { 4, 1, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5134), null },
                    { 3, 1, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5124), null },
                    { 3, 3, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5129), null },
                    { 7, 5, null, new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5543), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoCurso_CursoId",
                table: "AlunoCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PrerequisitoId",
                table: "Disciplinas",
                column: "PrerequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoCurso");

            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
