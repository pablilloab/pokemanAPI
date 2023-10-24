using PokemonReviewApp.Models;

namespace pokemonApi.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();

        Owner GetOwner(int ownerId);

        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);

        ICollection<Pokemon> GetPokemonByOwner (int  ownerId);

        bool OwnerExist (int ownerId);
    }
}
