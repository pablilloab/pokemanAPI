using Microsoft.EntityFrameworkCore;
using pokemonApi.Data;
using pokemonApi.Interfaces;
using PokemonReviewApp.Models;

namespace pokemonApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context) 
        {
            this._context = context;
        }

        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(pc =>  pc.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }
    }
}
