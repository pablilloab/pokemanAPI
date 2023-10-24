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

            CreateMap<Category, CategoryDto>();

            CreateMap<Country, CountryDto>();

            CreateMap<Owner, OwnerDto>();

            CreateMap<Review, ReviewDto>();
 
            CreateMap<Reviewer, ReviewerDto>();
        }
    }
}
