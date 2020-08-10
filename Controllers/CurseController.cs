using API.Dtos;
using API.Models;
using API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/curse")]
    [ApiController]
    public class CurseController : ControllerBase
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CurseController(IRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<CurseReadDto>> GetAllCurses()
        {
            IEnumerable<Curse> curses = repository.GetAllCurses();

            return Ok(mapper.Map<IEnumerable<CurseReadDto>>(curses));
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(CurseReadDto))]
        [ProducesResponseType(404)]
        public ActionResult<CurseReadDto> GetCurse(int id)
        {
            Curse curse = repository.GetCurseById(id);

            if (curse == null)
            {
                return NotFound();
            }

            CurseReadDto curseReadDto = mapper.Map<CurseReadDto>(curse);

            return Ok(curseReadDto);
        }
    }
}
