using PokemonReviewApp.Models;

namespace pokemonApi.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int id);
        ICollection<Review> GetReviewsOfAReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
    }
}
