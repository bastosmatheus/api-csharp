using MoviesApi.Models;

namespace MoviesApi.Repositories;

public interface IMovie
{
    public List<Movie> GetAllMovies();

    public Movie GetMovieById(int id);

    public void AddMovie(Movie movie);

    public void UpdateMovie(Movie movie);

    public void DeleteMovie(int id);
}
