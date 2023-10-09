using PokemonReviewApp.Models;

namespace pokemonApi.Interfaces
{
    public interface IPokemonRepository
    {
        //metodo q devuelve todos los pokemon 
        ICollection<Pokemon> GetPokemons();

        //pokemon por id
        Pokemon GetPokemon(int id);

        //pokemon por nombre
        Pokemon GetPokemon(string name);

        //pokemon por rating
        decimal GetPokemonRating(int pokeId);

        //check si el pokemon existe
        bool PokemonExists(int pokeId);


    }
}
