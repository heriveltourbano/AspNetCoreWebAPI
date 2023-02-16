﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.WebAPI.Data;

namespace SmartSchool.WebAPI.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20230213125913_initMySql")]
    partial class initMySql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 194, DateTimeKind.Local).AddTicks(8752),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(6822),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7066),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7100),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7124),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7172),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 195, DateTimeKind.Local).AddTicks(7198),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunoCurso");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Nota")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(2935)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5045)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5105)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5109)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5111)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5121)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5124)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5127)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5129)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5134)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5137)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5139)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5142)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5144)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5146)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5149)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5151)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5517)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5528)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5532)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5536)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5539)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2023, 2, 13, 9, 59, 12, 196, DateTimeKind.Local).AddTicks(5543)
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Curso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Registro")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInicio = new DateTime(2023, 2, 13, 9, 59, 12, 185, DateTimeKind.Local).AddTicks(2913),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInicio = new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8208),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInicio = new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8312),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInicio = new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8318),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInicio = new DateTime(2023, 2, 13, 9, 59, 12, 186, DateTimeKind.Local).AddTicks(8321),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("SmartSchool.WebAPI.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}