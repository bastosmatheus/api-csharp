using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers;

// indicando que � um Controller de uma API.
// definindo o endpoint. Nesse caso o parametro "[controller]" significa que o endpoint � o localhost:3000/movie
[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private static List<Movie> movies = new List<Movie>();

    // indicando que para a fun��o ser acionada, o m�todo a ser utilizado tem que ser o POST.
    // as fun��es a serem executadas, s� permitem o modificador de acesso PUBLIC.
    [HttpPost]
    public void AddMovie(/*[FromBody] = vem do body da requisi��o*/ [FromBody] Movie movie)
    {
        movies.Add(movie);
    }

    [HttpGet]
    public List<Movie> GetAllMovies()
    {
        return movies;
    }
}