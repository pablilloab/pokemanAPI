using pokemonApi.Data;
using pokemonApi.Interfaces;
using PokemonReviewApp.Models;

//falta crear el endpoint para traer pokemon por nombre

namespace pokemonApi.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        //Constructor que recibe el DataContext
        public PokemonRepository(DataContext contex)
        {
            this._context = contex;
        }

        //Implementaciones de la interfaz

        public Pokemon GetPokemon(int pokeId)
        {
            return _context.Pokemon.Where(p => p.Id == pokeId).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(r => r.Pokemon.Id == pokeId);

            if (review.Count() <= 0)
            {
                return 0;
            }

            return ((decimal)review.Sum(r => r.Rating)) / review.Count();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            //mi implementacion del metodo
            //if (_context.Pokemon.Where(p => p.Id == pokeId).FirstOrDefault() != null) {
            //    return true;
            //}
            //return false;

            //usando LINQ
            return _context.Pokemon.Any(p => p.Id == pokeId);
        }
    }
}
