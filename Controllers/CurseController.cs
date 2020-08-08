using API.Dtos;
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
        [ProducesResponseType(200,
        Type = typeof(IEnumerable<CurseReadDto>))]
        public IEnumerable<CurseReadDto> GetAllCurses()
        {
            var curses = repository.GetAllCurses();

            return mapper.Map<IEnumerable<CurseReadDto>>(curses);
        }
    }
}
