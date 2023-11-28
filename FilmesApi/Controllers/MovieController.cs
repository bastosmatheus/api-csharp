using Microsoft.AspNetCore.Mvc;
using MoviesApi.Models;
using MoviesApi.Repositories;

namespace MoviesApi.Controllers;

// indicando que é um Controller de uma API.
// definindo o endpoint. Nesse caso o parametro "[controller]" significa que o endpoint é o localhost:3000/movie
[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private readonly MovieRepository _movieRepository;

    [HttpGet]
    public List<Movie> GetAllMovies()
    {
        return _movieRepository.GetAllMovies();
    }

    // utilizando os parametros vindos da rota
    [HttpGet("{id}")]
    public Movie GetMovieById([FromRoute] int id)
    {
        return _movieRepository.GetMovieById(id);
    }

    // indicando que para a função ser acionada, o método a ser utilizado tem que ser o POST.
    // as funções a serem executadas, só permitem o modificador de acesso PUBLIC.
    [HttpPost]
    public void AddMovie(/*[FromBody] = vem do body da requisição*/ [FromBody] Movie movie)
    {
        _movieRepository.AddMovie(movie);
    }

    [HttpPut]
    public void UpdateMovie([FromBody] Movie movie)
    {
        _movieRepository.UpdateMovie(movie);
    }

    // utilizando os parametros vindos da rota.
    [HttpDelete("{id}")]
    public void DeleteMovie([FromRoute] int id)
    {
        _movieRepository.DeleteMovie(id);
    }
    
}