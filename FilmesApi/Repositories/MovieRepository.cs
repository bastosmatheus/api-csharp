using MoviesApi.Data;
using MoviesApi.Models;

namespace MoviesApi.Repositories;


// classe repository serve para separar a camada de acesso aos dados, da camdada de regras de negócio
public class MovieRepository : IMovie
{
    private readonly AppDbContext _context;

    public MovieRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Movie> GetAllMovies()
    {
        return _context.Movies.ToList();
    }

    public Movie GetMovieById(int id)
    {
        return _context.Movies.FirstOrDefault(m => m.Id == id);
    }

    public void AddMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    public void UpdateMovie(Movie movieUpdated)
    {
        _context.Movies.Update(movieUpdated);
        _context.SaveChanges();
    }

    public void DeleteMovie(int id)
    {
        Movie movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        _context.Movies.Remove(movie);
        _context.SaveChanges();
    }
}
