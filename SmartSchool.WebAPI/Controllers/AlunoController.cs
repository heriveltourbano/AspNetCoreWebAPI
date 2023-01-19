using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public readonly SmartContext _context;
        public AlunoController(SmartContext context){
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            //https://localhost:5001/api/aluno/byId/1
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            // https://localhost:5001/api/aluno/byName?nome=Marcos&sobrenome=Almeida
            var aluno = _context.Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }
        [HttpPost]
        public IActionResult Post(Aluno aluno){
            _context.Add(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("O aluno não foi encontrado");

            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno){
            var alu = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("O aluno não foi encontrado");

            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var alu = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("O aluno não foi encontrado");

            _context.Remove(alu);
            _context.SaveChanges();
            return Ok();
        }

    }
}