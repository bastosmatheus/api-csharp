using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Movie
{
    // data annotations - fornecem uma validação dos dados de entrada, vindos do usuário.
    
    [Required(ErrorMessage = "O campo MovieName não pode estar vazio.")]
    [MaxLength(50, ErrorMessage = "O filme deve ter menos de 50 caracteres.")]
    [MinLength(2, ErrorMessage = "O filme deve ter pelo menos 2 caracteres.")]
    public string MovieName { get; set; }

    [Required(ErrorMessage = "O campo Genre não pode estar vazio.")]
    [MaxLength(50, ErrorMessage = "Apenas genêros com menos de 50 caracteres são aceitos.")]
    [MinLength(2, ErrorMessage = "O genêro deve ter pelo menos 2 caracteres.")]
    public string Genre { get; set; }

    [Required(ErrorMessage = "O campo YearLaunch não pode estar vazio.")]
    // range serve para estipular um valor (int) max e min.
    [Range(1900, 2023, ErrorMessage = "O lançamento do filme deve estar dentro do periodo de 1900 e 2023")]
    public int YearLaunch { get; set; }

    [Required(ErrorMessage = "O campo DurationInMinutes não pode estar vazio.")]
    // range serve para estipular um valor (int) max e min.
    [Range(70, 400, ErrorMessage = "O filme deve ter entre 70 e 400 minutos.")]
    public int DurationInMinutes { get; set; }
}
