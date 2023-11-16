using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers;

// indicando que é um Controller de uma API.
// definindo o endpoint. Nesse caso o parametro "[controller]" significa que o endpoint é o localhost:3000/movie
[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private static List<Movie> movies = new List<Movie>();

    // indicando que para a função ser acionada, o método a ser utilizado tem que ser o POST.
    // as funções a serem executadas, só permitem o modificador de acesso PUBLIC.
    [HttpPost]
    public void AddMovie(/*[FromBody] = vem do body da requisição*/ [FromBody] Movie movie)
    {
        movies.Add(movie);
    }

    [HttpGet]
    public List<Movie> GetAllMovies()
    {
        return movies;
    }
}