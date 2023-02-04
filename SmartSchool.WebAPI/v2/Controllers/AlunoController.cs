using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.v2.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.v2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;
        private readonly IMapper _mapper;

        public AlunoController(IRepository repo, IMapper mapper){
            _repo = repo;
            _mapper = mapper;
        }

    /// <summary>
    /// Método responsável para retornar todos os meus alunos
    /// </summary>
    /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var alunos  = _repo.GetAllAlunos(true);
            return Ok(_mapper.Map<IEnumerable<AlunoDto>>(alunos));
        }

    /// <summary>
    /// Método responsável por retornar apenas um unico AlunoDTO
    /// </summary>
    /// <returns></returns>
        [HttpGet("getRegister")]
        public IActionResult GetRegister()
        {
            return Ok(new AlunoRegistrarDto());
        }

    /// <summary>
    /// Método responsável por retornar apenas um unico AlunoDTO filtrando por ID
    /// </summary>
    /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //https://localhost:5001/api/aluno/byId/1
            var aluno = _repo.GetAlunoById(id,false);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            var alunoDto = _mapper.Map<AlunoDto>(aluno);
            return Ok(alunoDto);
        }

    /// <summary>
    /// Método responsável por inserir um novo aluno
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Método responsável por alterar um aluno existente
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Método responsável por alterar um aluno existente
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Método responsável por excluir um aluno existente
    /// </summary>
    /// <returns></returns>
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