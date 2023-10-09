using AutoMapper;
using pokemonApi.Dto;
using PokemonReviewApp.Models;

namespace pokemonApi.Mapper
{
    public class MappinProfile : Profile
    {
        public MappinProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
