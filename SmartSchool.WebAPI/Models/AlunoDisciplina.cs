using System;

namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaId;
        }
        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public int? Nota { get; set; } = null;
        public AlunoDisciplina(){ }  
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}