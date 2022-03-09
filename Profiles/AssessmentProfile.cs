using Assessment.Dtos;
using Assessment.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Profiles
{
    public class AssessmentProfile : Profile
    {
        public AssessmentProfile()
        {
            //soource --> target
            CreateMap<Match, MatchReadDto>()
                    .ForMember(c => c.Discription, o => o.MapFrom(src => src.Discription))
                    .ForMember(c => c.MatchDate, o => o.MapFrom(src => src.MatchDate.ToShortDateString()))
                    .ForMember(c => c.MatchTime, o => o.MapFrom(src => src.MatchDate.ToShortTimeString()));
            CreateMap<MatchCreateDto, Match>();
            CreateMap<MatchUpdateDto, Match>();
            CreateMap<Match, MatchUpdateDto>();


            CreateMap<MatchOdd, MatchOddReadDto>()
                .ForMember(c => c.Specifier, o => o.MapFrom(src => src.Specifier));
            CreateMap<MatchOddCreateDto, MatchOdd>();
            CreateMap<MatchOddUpdateDto, MatchOdd>();
            CreateMap<MatchOdd, MatchOddUpdateDto>();
        }
    }
}
