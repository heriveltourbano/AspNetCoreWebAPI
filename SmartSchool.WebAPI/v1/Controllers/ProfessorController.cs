using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.v1.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public readonly IRepository _repo;
        private readonly IMapper _mapper;

        public ProfessorController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var professores =  _repo.GetAllProfessores(true);
            return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(professores));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetProfessorById(id,true);
            if (professor == null) return BadRequest("Professor não encontrado");

            return Ok(_mapper.Map<ProfessorDto>(professor));
        }

        [HttpPost]
        public IActionResult Post(ProfessorRegistrarDto model)
        {
            var professor = _mapper.Map<Professor>(model);
            _repo.Add(professor);
            if (_repo.SaveChanges())
            {
                return Created($"/api/professor/{model.Id}",_mapper.Map<ProfessorDto>(professor));
            }
            return BadRequest("Professor não cadastrado");
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistrarDto model)
        {
            var pro = _repo.GetProfessorById(id,false);
            if (pro == null) return BadRequest("Professor não encontrado");

            _mapper.Map(model, pro);
            _repo.Update(pro);
            if (_repo.SaveChanges())
            {
                return Created($"/api/professor/{model.Id}",_mapper.Map<ProfessorDto>(pro));
            }
            return BadRequest("Professor não atualizado");
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistrarDto model)
        {
            var pro = _repo.GetProfessorById(id,false);
            if (pro == null) return BadRequest("Professor não encontrado");

            _mapper.Map(model, pro);
            _repo.Update(pro);
            if (_repo.SaveChanges())
            {
                return Created($"/api/professor/{model.Id}",_mapper.Map<ProfessorDto>(pro));
            }
            return BadRequest("Professor não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pro = _repo.GetProfessorById(id,false);
            if (pro == null) return BadRequest("Professor não encontrado");

            _repo.Delete(pro);
            if (_repo.SaveChanges())
            {
                return Ok("Professor excluído");
            }

            return BadRequest("Professor não excluído");
        }
    }
}