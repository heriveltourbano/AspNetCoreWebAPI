using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;
        private readonly IMapper _mapper;

        public AlunoController(IRepository repo, IMapper mapper){
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var alunos  = _repo.GetAllAlunos(true);
            return Ok(_mapper.Map<IEnumerable<AlunoDto>>(alunos));
        }

        [HttpGet("getRegister")]
        public IActionResult GetRegister()
        {
            return Ok(new AlunoRegistrarDto());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //https://localhost:5001/api/aluno/byId/1
            var aluno = _repo.GetAlunoById(id,false);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            var alunoDto = _mapper.Map<AlunoDto>(aluno);
            return Ok(alunoDto);
        }

        [HttpPost]
        public IActionResult Post(AlunoRegistrarDto model){
            var aluno = _mapper.Map<Aluno>(model);

            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}",_mapper.Map<AlunoDto>(aluno));
            }
            return BadRequest("Aluno não cadastrado");
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoRegistrarDto model)
        {
            var alu = _repo.GetAlunoById(id,false);
            if (alu == null) return BadRequest("O aluno não foi encontrado");

            _mapper.Map(model, alu);

            _repo.Update(alu);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}",_mapper.Map<AlunoDto>(alu));
            }
            return BadRequest("Aluno não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, AlunoRegistrarDto model){
             var alu = _repo.GetAlunoById(id,false);
            if (alu == null) return BadRequest("O aluno não foi encontrado");

            _mapper.Map(model, alu);

            _repo.Update(alu);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}",_mapper.Map<AlunoDto>(alu));
            }
            return BadRequest("Aluno não atualizado");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var alu = _repo.GetAlunoById(id,false);
            if (alu == null) return BadRequest("O aluno não foi encontrado");

            _repo.Delete(alu);
            if (_repo.SaveChanges())
            {
                return Ok("Aluno deletado");
            }
            return BadRequest("Aluno não excluído");
        }

    }
}