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
    [Route("api/MatchOdds")]
    [ApiController]
    public class MatchOddsController : ControllerBase
    {
        private readonly IMatchOddRepo _repository;
        private readonly IMapper _mapper;

        public MatchOddsController(IMatchOddRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/MatchOdds
        [HttpGet]
        public ActionResult<IEnumerable<MatchOddReadDto>> GetAllOdds()
        {
            var oddItems = _repository.GetAllOdds();

            return Ok(_mapper.Map<IEnumerable<MatchOddReadDto>>(oddItems));
        }

        //GET api/MatchOdds/{id}
        [HttpGet("{Id}", Name = "GetOddById")]
        public ActionResult<MatchReadDto> GetOddById(long Id)
        {
            var oddItem = _repository.GetOddById(Id);

            if (oddItem != null)
                return Ok(_mapper.Map<MatchOddReadDto>(oddItem));

            return NotFound();
        }

        //POST api/MatchOdds
        [HttpPost]
        public ActionResult<MatchReadDto> CreateMatchOdd(MatchOddCreateDto matchOddCreateDto)
        {
            var matchOddModel = _mapper.Map<MatchOdd>(matchOddCreateDto);
            _repository.CreateMatchOdd(matchOddModel);
            _repository.SaveChanges();

            var matchOddReadDto = _mapper.Map<MatchOddReadDto>(matchOddModel);


            return CreatedAtRoute(nameof(GetOddById), new { Id = matchOddReadDto.Id }, matchOddReadDto);
        }

        //PUT api/MatchOdds/{id}
        [HttpPut("{Id}")]
        public ActionResult UpdateMatchOdd(long Id, MatchOddUpdateDto matchOddUpdateDto)
        {
            var matchOddModelFromRepo = _repository.GetOddById(Id);
            if (matchOddModelFromRepo is null)
                return NotFound();

            _mapper.Map(matchOddUpdateDto, matchOddModelFromRepo);

            _repository.UpdateMatchOdd(matchOddModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/MatchOdds/{id}
        [HttpDelete("{Id}")]
        public ActionResult DeleteMatchOddById(long Id)
        {
            var matchOddModelFromRepo = _repository.GetOddById(Id);
            if (matchOddModelFromRepo is null)
                return NotFound();

            _repository.DeleteMatchOdd(matchOddModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}
