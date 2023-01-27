namespace SmartSchool.WebAPI.Data
{
using SmartSchool.WebAPI.Models;

public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;
        bool SaveChanges();
        void Delete<T>(T entity) where T : class;

        public Aluno[] GetAllAlunos(bool includeProfessor = false);
        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        public Aluno GetAlunoById(int alunoId, bool includeProfessor = false);
        public Professor[] GetAllProfessores(bool includeAluno = false);
        public Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAluno = false);
        public Professor GetProfessorById(int professorId, bool includeAluno = false);
        
    }
}