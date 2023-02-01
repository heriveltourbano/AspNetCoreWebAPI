using System;
using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor(int id, 
                        int registro, 
                        string nome, 
                        string sobrenome = null)
        {
            this.Id = id;
            this.Nome = nome;
            this.Registro = registro;
            this.Sobrenome = sobrenome;
        }
        public Professor(){ }
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool  Ativo { get; set; } = true;
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}