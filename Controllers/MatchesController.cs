using Assessment.Data;
using Assessment.Dtos;
using Assessment.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Controllers
{

    [Route("api/matches")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly IMatchRepo _repository;
        private readonly IMapper _mapper;

        public MatchesController(IMatchRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/matches
        [HttpGet]
        public ActionResult<IEnumerable<MatchReadDto>> GetAllMatches()
        {
            var matchItems = _repository.GetAllMatches();

            return Ok(_mapper.Map<IEnumerable<MatchReadDto>>(matchItems));
        }

        //GET api/matches/{id}
        [HttpGet("{Id}", Name = "GetMatchById")]
        public ActionResult<MatchReadDto> GetMatchById(long Id)
        {
            var matchItem = _repository.GetMatchById(Id);

            if(matchItem != null)
                return Ok(_mapper.Map<MatchReadDto>(matchItem));

            return NotFound();
        }

        //POST api/matches
        [HttpPost]
        public ActionResult<MatchReadDto> CreateMatch(MatchCreateDto matchCreateDto)
        {
            var matchModel = _mapper.Map<Match>(matchCreateDto);
            _repository.CreateMatch(matchModel);
            _repository.SaveChanges();

            var matchReadDto = _mapper.Map<MatchReadDto>(matchModel);


            return CreatedAtRoute(nameof(GetMatchById), new { Id = matchReadDto.Id }, matchReadDto);
        }

        //PUT api/matches/{id}
        [HttpPut("{Id}")]
        public ActionResult UpdateMatch(long Id, MatchUpdateDto matchUpdateDto)
        {
            var matchModelFromRepo = _repository.GetMatchById(Id);
            if (matchModelFromRepo is null)
                return NotFound();

            _mapper.Map(matchUpdateDto, matchModelFromRepo);

            _repository.UpdateMatch(matchModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/matches/{id}
        [HttpDelete("{Id}")]
        public ActionResult DeleteMatchById(long Id)
        {
            var matchModelFromRepo = _repository.GetMatchById(Id);
            if (matchModelFromRepo is null)
                return NotFound();

            _repository.DeleteMatch(matchModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
