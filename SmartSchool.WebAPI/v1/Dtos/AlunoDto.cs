using System;

namespace SmartSchool.WebAPI.v1.Dtos
{
        /// <summary>
        /// Este é o DTO de Aluno para registrar
        /// </summary>
    public class AlunoDto
    {
        /// <summary>
        /// Identificador e chave do Banco
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Chave do Aluno, para outros negócios na Instituição
        /// </summary>
        public int Matricula { get; set; }
        /// <summary>
        /// Nome é o primeiro nome e o sobrenome do aluno
        /// </summary>
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public DateTime DataIni { get; set; } 
        public bool Ativo { get; set; } = true;
    }
}