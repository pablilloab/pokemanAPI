using PokemonReviewApp.Models;

namespace pokemonApi.Interfaces
{
    public interface ICountryRepository
    {
        //en la interface se crean los metodos que seran implementados en la clase.
        ICollection<Country> GetCountries();

        Country GetCountry(int countryId);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int countryId);
    }
}
